// Configure conditional compilation symbols in the Project properties Build page.
//
// Debug configurations default to DISABLE_THREADS.
// Add ENABLE_THREADS to the compilation symbols to enable threading.
//
// Release configurations default to ENABLE_THREADS.
// Add DISABLE_THREADS to the compilation symbols to disable threading.

// don't change
#if !ENABLE_MODS && !DISABLE_MODS
    #if DEBUG
        #define DISABLE_THREADS
    #else
        #define ENABLE_THREADS
    #endif
#endif

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

using libMBIN;

namespace MBINCompiler.Commands {

    using static CommandLineOptions;

    internal static class Convert {

        private static int currentIndent = 0;

        public static ErrorCode ConvertFileList( string inputDir, string outputDir, List<string> fileList, bool force ) {
            var locked = new object(); // for syncing thread access to volatile data

            var failedFiles = new List<string>();
            var exceptions = new List<Exception>();
            var errorCode = ErrorCode.Success;
            var tasks = new List<Task>();
            var timer = new Stopwatch();
            timer.Start();
            currentIndent = Logger.IndentLevel;
            foreach ( var fileIn in fileList ) {
                var path = fileIn;
                if ( outputDir != null ) path = fileIn.Substring( inputDir.Length + 1 );
                string fileOut = fileIn;
                if ( outputDir != null ) fileOut = fileOut.Replace( inputDir, outputDir );
                RunTask( tasks, () => {
                    try {
                        Logger.IndentLevel = currentIndent; // we need to reset the indent level for each thread otherwise it will accumulate
                        #if DEBUG
                            Logger.LogInfo( $"Converting {path}" );
                        #else
                            Console.WriteLine( $"Converting {path}" );
                        #endif
                        ConvertFile( fileIn, fileOut, InputFormat, OutputFormat );

                    } catch ( System.Exception e ) {
                        if ( !force ) throw;
                        lock ( locked ) {
                            failedFiles.Add( path );
                            exceptions.Add( e );
                            errorCode = (ErrorCode) CommandLine.ShowException( e, false );
                            Console.WriteLine();
                        }
                    }
                } );
            }
            WaitForTasks( tasks );

            Logger.LogInfo( $"\n{fileList.Count - failedFiles.Count} files successfully converted." );
            if ( failedFiles.Count > 0 ) {
                Logger.LogInfo( $"{failedFiles.Count} FILES FAILED.\n" );
                #if !DEBUG
                    using ( var indentScope = new Logger.IndentScope() ) {
                        for ( int i = 0; i < failedFiles.Count; i++ ) {
                            Console.WriteLine( Logger.IndentString( string.Format( "FILE: {0}", failedFiles[i] ) ) );
                            if ( exceptions[i].GetType() == typeof( CompilerException ) ) exceptions[i] = exceptions[i].InnerException;
                            Console.WriteLine( Logger.IndentString( string.Format( "ERROR: {0}\n", exceptions[i].Message ) ) );
                        }
                    }
                #endif
            }

            //#if DEBUG
                Logger.LogInfo( "TIME: {0} seconds", timer.ElapsedMilliseconds / 1e3f );
            //#endif
            return errorCode;
        }

        private static void RunTask( List<Task> tasks, Action action ) {
            #if ENABLE_THREADS
                if (UseThreads) { tasks.Add( Task.Factory.StartNew( action ) ); return; }
            #endif
            action();
        }

        [Conditional( "ENABLE_THREADS" )]
        private static void WaitForTasks( List<Task> tasks ) { if (UseThreads) Task.WaitAll( tasks.ToArray() ); }

        public static void ConvertFile( string fileIn, string fileOut, FormatType inputFormat, FormatType outputFormat ) {
            fileOut = ChangeFileExtension( fileOut, outputFormat );

            Directory.CreateDirectory( Path.GetDirectoryName( fileOut ) );

            try {
                using ( var indentScope = new Logger.IndentScope() ) // not thread-safe? :/
                using ( var fIn = new FileStream( fileIn, FileMode.Open, FileAccess.Read ) )
                using ( var ms = new MemoryStream() ) {

                    if ( inputFormat == FormatType.MBIN ) {
                        var mbin = new MBINFile( fIn );
                        if ( !mbin.Load() || !mbin.Header.IsValid ) throw new InvalidDataException( "Not a valid MBIN file!" );

                        var sw = new StreamWriter( ms );

                        NMSTemplate data = null;
                        try {
                            data = mbin.GetData();
                            if ( data is null ) throw new InvalidDataException( "Invalid MBIN data." );
                        } catch ( Exception e ) {
                            throw new MbinException( $"Failed to read {mbin.Header.GetXMLTemplateName()} from MBIN.", e, fileIn, mbin );
                        }

                        try {
                            sw.Write( EXmlFile.WriteTemplate( data ) );
                            sw.Flush();
                            if ( ms.Length == 0 ) throw new InvalidDataException( "Invalid EXML data." );
                        } catch ( Exception e ) {
                            throw new MbinException( $"Failed serializing {mbin.Header.GetXMLTemplateName()} to EXML.", e, fileIn, mbin );
                        }

                    } else if ( inputFormat == FormatType.EXML ) {
                        NMSTemplate data = null;
                        try {
                            data = EXmlFile.ReadTemplateFromStream( fIn );
                            if ( data is null ) throw new InvalidDataException( $"Failed to deserialize EXML." );
                            if ( data is libMBIN.NMS.Toolkit.TkGeometryData | data is libMBIN.NMS.Toolkit.TkGeometryStreamData ) fileOut += ".PC";
                            var mbin = new MBINFile( ms ) { Header = new MBINHeader() };
                            mbin.Header.SetDefaults( data.GetType() );
                            mbin.SetData( data );
                            mbin.Save();
                        } catch ( Exception e ) {
                            throw new ExmlException( e, fileIn, data );
                        }

                    }

                    ms.Flush();
                    FileMode fileMode = GetFileMode(fileOut);
                    using ( var fOut = new FileStream( fileOut, fileMode, FileAccess.Write ) ) ms.WriteTo( fOut );
                }
            } catch ( Exception e ) {
                if ( e is CompilerException ) throw;
                throw new CompilerException( e, fileIn );
            }

        }

        private static string ChangeFileExtension( string file, FormatType format ) {
            string ext = format.ToString().ToUpper();
            if ( Path.HasExtension( file ) ) {
                string x = Path.GetExtension( file ).ToUpper();
                if ( x == ".PC" ) file = Path.ChangeExtension( file, null );
                x = Path.GetExtension( file ).ToUpper();
                if ( x == ".MBIN" ) return Path.ChangeExtension( file, ext );
                if ( x == ".EXML" ) return Path.ChangeExtension( file, ext );
            }
            return file + $".{ext}";
        }

        /// <summary>
        /// Gets the appropriate file mode based on the Overwrite option setting.
        /// For output files. If file exists and Overwrite is Prompt, the user will be asked
        /// how to handle the file.
        /// </summary>
        /// <param name="file">The file path to check.</param>
        /// <returns>A FileMode enum. The value is 0 if the user opted to keep the existing file.</returns>
        private static FileMode GetFileMode( string file ) {
            if ( Overwrite == OverwriteMode.Always ) {
                return FileMode.Create;
            } else if ( Overwrite == OverwriteMode.Prompt ) {
                if ( File.Exists( file ) ) {
                    if ( Utils.PromptOverwrite( file, ref OptionBackers.optOverwrite ) ) return FileMode.Create;
                    throw new IOException( "The destination file already exists!" );
                }
            }
            return FileMode.CreateNew; // OverwriteMode.Never or file doesn't exist
        }

    }

}
