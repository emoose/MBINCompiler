using System;
using System.IO;
using System.Collections.Generic;

using libMBIN;

namespace MBINCompiler.Commands {

    using static CommandLineOptions;

    internal class ConvertCommand : Command<ConvertCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            var paths = options.GetFileParams();

            if ( !GetOverwriteOption( options ) ) return (int) ErrorCode.CommandLine;

            var force = options.GetOptionSwitch( "force" );

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
                defaultInclude = "*.MBIN;*.MBIN.PC;*.EXML";
            } else {
                if ( !SetFormatOptions( formatI, formatO ) ) return (int) ErrorCode.CommandLine;
                defaultInclude = (InputFormat == FormatType.MBIN) ? "*.MBIN;*.MBIN.PC" : "*.EXML";
            }

            IncludeFilters = new List<string>( (optIncludes?.value ?? defaultInclude).Split( ';' ) );
            ExcludeFilters = new List<string>( (optExcludes?.value ?? @"LANGUAGE\*;*.GEOMETRY.*").Split( ';' ) );
            // if not auto-detecting then OutputFormat can be excluded
            if ( !autoFormat ) ExcludeFilters.Add( $"*.{OutputFormat}" );

            // generate a filtered file listing of the combined paths
            if ( !GetFileList( paths, out var fileList ) ) return (int) ErrorCode.CommandLine;

            // auto detect the input format if necessary
            if ( autoFormat && !AutoDetectFormat( fileList ) ) return (int) ErrorCode.Unknown;

            return (int) Convert.ConvertFileList( inputDir, outputDir, fileList, force );
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
                InputFormat = (formatI == "EXML") ? FormatType.EXML : InputFormat;
                if ( InputFormat == FormatType.Unknown ) {
                    CommandLine.ShowCommandLineError( $"Invalid format specified: {formatI}" );
                    return false;
                }
            }

            if ( formatO != null ) {
                OutputFormat = (formatO == "MBIN") ? FormatType.MBIN : OutputFormat;
                OutputFormat = (formatO == "EXML") ? FormatType.EXML : OutputFormat;
                if ( OutputFormat == FormatType.Unknown ) {
                    CommandLine.ShowCommandLineError( $"Invalid format specified: {formatO}" );
                    return false;
                }
            }

            if ( formatI == null ) InputFormat = (OutputFormat == FormatType.MBIN) ? FormatType.EXML : FormatType.MBIN;
            if ( formatO == null ) OutputFormat = (InputFormat == FormatType.MBIN) ? FormatType.EXML : FormatType.MBIN;

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

            var includeFiles = new List<string>();
            var excludeFiles = new List<string>();
            foreach ( var filter in IncludeFilters ) {
                includeFiles.AddRange( GetDirectoryFiles( path, filter ) );
            }
            foreach ( var filter in ExcludeFilters ) {
                excludeFiles.AddRange( GetDirectoryFiles( path, filter ) );
            }

            // add the filtered files to fileList
            foreach ( var file in includeFiles ) {
                if ( !excludeFiles.Contains( file ) ) files.Add( file );
            }

            return files;
        }

        private static string[] GetDirectoryFiles( string path, string filter ) {
            try {
                return Directory.GetFiles( path, filter, SearchOption.AllDirectories );
            } catch ( DirectoryNotFoundException ) { }
            return new string[] { };
        }

        private static bool AutoDetectFormat( List<string> fileList ) {
            // detect what types of file formats are found
            bool foundMBIN = false;
            bool foundEXML = false;
            foreach ( var file in fileList ) {
                if ( Path.HasExtension( file ) ) {
                    var ext = Path.GetExtension( file ).ToUpper();
                    foundMBIN |= (ext == ".MBIN") || (ext == ".PC");
                    foundEXML |= (ext == ".EXML");
                }
            }

            // TODO: this should be handled better
            if ( !foundMBIN && !foundEXML ) {
                if ( (fileList.Count == 1) && File.Exists( fileList[0] ) ) {
                    using ( var fIn = new FileStream( fileList[0], FileMode.Open ) ) {
                        // possibly MBIN? check for a valid header
                        using ( var mbin = new MBINFile( fIn, true ) ) foundMBIN = (mbin.Load() && mbin.Header.IsValid);
                        if ( !foundMBIN ) { // possibly EXML? check for a valid xml tag
                            var xmlTag = "<?xml version=\"1.0\" encoding=\"utf-8\"?>".ToLower();
                            var bytes = new byte[xmlTag.Length];
                            // TODO: handle potential leading whitespace?
                            if ( fIn.Read( bytes, 0, xmlTag.Length ) == xmlTag.Length ) {
                                var txt = System.Text.Encoding.ASCII.GetString( bytes ).ToLower();
                                foundEXML = (txt == xmlTag);
                            }
                        }
                    }
                }
            }

            if ( foundMBIN && foundEXML ) {
                const string msg = "Unable to automatically determine the --input-format type.";
                if ( Quiet ) return (CommandLine.ShowError( msg ) == (int) ErrorCode.Success);
                CommandLine.ShowWarning( msg );
                Console.Out.WriteLine( "Both MBIN and EXML file types were detected!\n" );
                InputFormat = Utils.PromptInputFormat();
                Console.Out.WriteLine();
            } else if ( foundMBIN ) {
                Logger.LogInfo( "Auto-Detected --input-format=MBIN\n" );
                InputFormat = FormatType.MBIN;
            } else if ( foundEXML ) {
                Logger.LogInfo( "Auto-Detected --input-format=EXML\n" );
                InputFormat = FormatType.EXML;
            } else {
                CommandLine.ShowError( "No valid files found!" );
                return false;
            }

            OutputFormat = (InputFormat == FormatType.MBIN) ? FormatType.EXML : FormatType.MBIN;
            Logger.LogDebug( $"--input-format={InputFormat} --output-format={OutputFormat}\n" );

            return true;
        }

    }

}
