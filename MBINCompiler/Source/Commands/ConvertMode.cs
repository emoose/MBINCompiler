using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using libMBIN;

namespace MBINCompiler.Commands {

    using static CommandLineOptions;

    public static class StringExtensions {
        /// <summary>
        /// Compares the string against a given pattern.
        /// Code credit: https://stackoverflow.com/a/4146349
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="pattern">The pattern to match, where "*" means any sequence of characters, and "?" means any single character.</param>
        /// <returns><c>true</c> if the string matches the given pattern; otherwise <c>false</c>.</returns>
        public static bool Like(this string str, string pattern)
        {
            return new Regex(
                "^" + Regex.Escape(pattern).Replace(@"\*", ".*").Replace(@"\?", ".") + "$",
                RegexOptions.IgnoreCase | RegexOptions.Singleline
            ).IsMatch(str);
        }
    }

    internal class ConvertCommand : Command<ConvertCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            var paths = options.GetFileParams();

            if ( !GetOverwriteOption( options ) ) return (int) ErrorCode.CommandLine;

            IgnoreErrors = options.GetOptionSwitch( "force" );
            UseThreads   = !options.GetOptionSwitch( "no-threads" );
            StreamToConsole = options.GetOptionSwitch("stream");
            HideVersionInfo = options.GetOptionSwitch("no-version");
            IncludeTypeInfo   = options.GetOptionSwitch( "typed" );
            
            var arg = options.GetOptionArg( "format-version" );
            if ( arg != null ) {
                MBINHeader.Format version;
                if ( !Enum.TryParse( arg.value, out version ) ) return CommandLine.ShowInvalidCommandLineArg( $"{arg.name}={arg.value}" );
                FormatVersion = version;
            }

            if ( paths.Count < 1 ) return CommandLine.ShowHelp( ErrorCode.CommandLine );
            var inputDir = paths[0];
            var outputDir = options.GetOptionArg( "output-dir" )?.value;
            if ( outputDir != null ) {
                if ( paths.Count > 1 ) return CommandLine.ShowInvalidCommandLineArg( paths[1] );
                outputDir = Path.GetFullPath( outputDir );
            }
            if ( File.Exists( inputDir ) ) inputDir = Path.GetDirectoryName( inputDir );
            inputDir = Path.GetFullPath( Path.Combine( inputDir, "." ) );

            var optFormatI = options.GetOptionArg( "input-format" );
            var optFormatO = options.GetOptionArg( "output-format" );

            var optIncludes = options.GetOptionArg( "include" );
            var optExcludes = options.GetOptionArg( "exclude" );

            var formatI = optFormatI?.value.ToUpper();
            var formatO = optFormatO?.value.ToUpper();

            // handle --input-format and --output-format options
            // and set the default include filters accordingly
            var defaultInclude = "*";
            bool autoFormat = (formatI == null) && (formatO == null);
            if ( autoFormat ) {
                defaultInclude = "*.MBIN;*.MBIN.PC;*.MXML";
            } else {
                if ( !SetFormatOptions( formatI, formatO ) ) return (int) ErrorCode.CommandLine;
                defaultInclude = (InputFormat == FormatType.MBIN) ? "*.MBIN;*.MBIN.PC" : "*.MXML";
            }

            var defaultExclude = @"";

            IncludeFilters = new List<string>((optIncludes?.value.ToUpper() ?? defaultInclude).Split(';'));
            ExcludeFilters = new List<string>((optExcludes?.value.ToUpper() ?? defaultExclude).Split(';'));

            // if not auto-detecting then OutputFormat can be excluded
            if ( !autoFormat ) ExcludeFilters.Add( $"*.{OutputFormat}" );

            // to remove any empty entry, otherwise all files are excluded
            for (int i = ExcludeFilters.Count - 1; i >= 0; i--)
            {
                if (ExcludeFilters[i] == "" || ExcludeFilters[i] == " ") ExcludeFilters.RemoveAt(i);
            }

            // generate a filtered file listing of the combined paths
            if ( !GetFileList( paths, out var fileList ) ) return (int) ErrorCode.CommandLine;

            // auto detect the input format if necessary
            if ( autoFormat && !AutoDetectFormat( ref fileList ) ) return (int) ErrorCode.Unknown;

            return (int) Convert.ConvertFileList( inputDir, outputDir, fileList, IgnoreErrors );
        }

        private static bool GetOverwriteOption( CommandLineParser options ) {
            var optO = options.GetOptionArg( "overwrite" );
            var optK = options.GetOptionArg( "keep" );
            bool isO = (optO != null);
            bool isK = (optK != null);
            if ( isO && isK ) {
                CommandLine.ShowCommandLineError( $"The {optO.name} and {optK.name} options cannot be used together." );
                return false;
            }

            Overwrite = isO ? OverwriteMode.Always : isK ? OverwriteMode.Never : OverwriteMode.Prompt;
            return true;
        }

        private static bool SetFormatOptions( string formatI, string formatO ) {
            if ( formatI != null ) {
                InputFormat = (formatI == "MBIN") ? FormatType.MBIN : InputFormat;
                InputFormat = (formatI == "MXML") ? FormatType.MXML : InputFormat;
                if ( InputFormat == FormatType.Unknown ) {
                    CommandLine.ShowCommandLineError( $"Invalid format specified: {formatI}" );
                    return false;
                }
            }

            if ( formatO != null ) {
                OutputFormat = (formatO == "MBIN") ? FormatType.MBIN : OutputFormat;
                OutputFormat = (formatO == "MXML") ? FormatType.MXML : OutputFormat;
                OutputFormat = (formatO == "EXML") ? FormatType.EXML : OutputFormat;
                if ( OutputFormat == FormatType.Unknown ) {
                    CommandLine.ShowCommandLineError( $"Invalid format specified: {formatO}" );
                    return false;
                }
            }

            if ( formatI == null ) InputFormat = (OutputFormat == FormatType.MBIN) ? FormatType.MXML : FormatType.MBIN;
            if ( formatO == null ) OutputFormat = (InputFormat == FormatType.MBIN) ? FormatType.MXML : FormatType.MBIN;

            if ( InputFormat == OutputFormat ) {
                CommandLine.ShowCommandLineError( "--input-format and --output-format cannot be the same type!" );
                return false;
            }

            return true;
        }

        private static bool GetFileList( List<string> paths, out List<string> fileList ) {
            fileList = new List<string>();
            foreach ( var path in paths ) {
                var fullpath = Path.GetFullPath( path );
                if ( File.Exists( fullpath ) ) {
                    fileList.Add( fullpath );
                } else if ( Directory.Exists( fullpath ) ) {
                    fileList.AddRange( GetFilteredFiles( fullpath ) );
                } else {
                    CommandLine.ShowCommandLineError( $"Invalid path.\n\"{path}\"" );
                    return false;
                }
            }

            return true;
        }

        private static List<string> GetFilteredFiles( string path ) {
            var files = new List<string>();

            var allFiles = Directory.EnumerateFiles(path, "", SearchOption.AllDirectories);
            foreach (string fname in allFiles) {
                string upperFname = fname.ToUpper();
                if (ExcludeFilters.Count > 0) {
                    if (ExcludeFilters.Any(ext => upperFname.Like(ext))) {
                        continue;
                    }
                }
                if (IncludeFilters.Any(ext => upperFname.Like(ext))) {
                    files.Add(fname);
                }
            }

            return files;
        }

        private static string DetectFormat( string file, ref bool foundMBIN, ref bool foundMXML ) {
            if ( Path.HasExtension( file ) ) {
                var ext = Path.GetExtension( file ).ToUpper();
                foundMBIN |= (ext == ".MBIN") || (ext == ".PC");
                foundMXML |= (ext == ".MXML");
            }
            return file;
        }

        private static bool AutoDetectFormat( ref List<string> fileList ) {
            // detect what types of file formats are found
            bool foundMBIN = false;
            bool foundMXML = false;

            foreach ( var file in fileList ) DetectFormat( file, ref foundMBIN, ref foundMXML );

            // TODO: this should be handled better
            if ( !foundMBIN && !foundMXML ) {
                if ( (fileList.Count == 1) && File.Exists( fileList[0] ) ) {
                    using ( var fIn = new FileStream( fileList[0], FileMode.Open ) ) {
                        // possibly MBIN? check for a valid header
                        using ( var mbin = new MBINFile( fIn, true ) ) foundMBIN = (mbin.Load() && mbin.Header.IsValid);
                        if ( !foundMBIN ) { // possibly MXML? check for a valid xml tag
                            var xmlTag = "<?xml version=\"1.0\" encoding=\"utf-8\"?>".ToLower();
                            var bytes = new byte[xmlTag.Length];
                            // TODO: handle potential leading whitespace?
                            if ( fIn.Read( bytes, 0, xmlTag.Length ) == xmlTag.Length ) {
                                var txt = System.Text.Encoding.ASCII.GetString( bytes ).ToLower();
                                foundMXML = (txt == xmlTag);
                            }
                        }
                    }
                }
            }

            if ( foundMBIN && foundMXML ) {
                const string msg = "Unable to automatically determine the --input-format type.";
                if ( Quiet ) return (CommandLine.ShowError( msg ) == (int) ErrorCode.Success);
                CommandLine.ShowWarning( msg );
                Console.Out.WriteLine( "Both MBIN and MXML file types were detected!\n" );
                InputFormat = Utils.PromptInputFormat();
                Console.WriteLine();
            } else if ( foundMBIN ) {
                if (!StreamToConsole) Logger.LogInfo( "Auto-Detected --input-format=MBIN" );
                InputFormat = FormatType.MBIN;
            } else if ( foundMXML ) {
                if (!StreamToConsole) Logger.LogInfo( "Auto-Detected --input-format=MXML" );
                InputFormat = FormatType.MXML;
            } else {
                CommandLine.ShowError( "No valid files found!" );
                return false;
            }

            OutputFormat = (InputFormat == FormatType.MBIN) ? FormatType.MXML : FormatType.MBIN;
            Logger.LogMessage( "INFO", $"--input-format={InputFormat} --output-format={OutputFormat}" );

            // exclude any files that don't match InputFormat
            for (int i = fileList.Count - 1; i >= 0; i--) {
                var ext = Path.GetExtension(fileList[i]).ToUpper();
                if (ext == ".PC") {
                    ext = Path.GetExtension(Path.ChangeExtension(fileList[i], null)).ToUpper();
                }
                if (ext.Substring(1) != InputFormat.ToString()) fileList.RemoveAt(i);
            }

            return true;
        }

    }

}
