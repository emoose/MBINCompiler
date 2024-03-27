﻿using System;

using libMBIN;

namespace MBINCompiler {
    using System.IO;
    using static CommandLineOptions;

    internal static class CommandLine
    {

        // Console.Out and Console.Error streams unaffected by Quiet option.
        private static TextWriter StandardOut = null;
        private static TextWriter StandardErr = null;

        public static void Initialize() {
            StandardOut = Console.Out;
            StandardErr = Console.Error;
        }

        public class ForceConsoleOutput : IDisposable {
            private readonly TextWriter stdout;
            private readonly TextWriter stderr;

            public ForceConsoleOutput() {
                stdout = Console.Out;
                stderr = Console.Error;
                Console.SetOut(   StandardOut );
                Console.SetError( StandardErr );
            }

            public void Dispose() {
                Console.SetOut( stdout );
                Console.SetError( stderr );
            }
        }

        /// <summary>
        /// Display the help info and wait for a key press.
        /// </summary>
        /// <returns>Always returns 0 (exit code = success)</returns>
        public static int ShowHelp( ErrorCode code = ErrorCode.Success )
        {
            if (Console.IsOutputRedirected) return (int) code;
            using ( var forceConsole = new ForceConsoleOutput() ) {
                Console.Out.Write( GetHelpInfo() );
            }
            WaitForKeypress();
            return (int) code;
        }

        public static int ShowSuccess(ErrorCode code = ErrorCode.Success)
        {
            if (Console.IsOutputRedirected) return (int)code;
            using (var forceConsole = new ForceConsoleOutput())
            {
                Console.Out.Write("MBINCompiler registered to the system path.");
            }
            WaitForKeypress();
            return (int)code;
        }

        private static long lastPosition = 0;

        public static int ShowException( Exception e, bool wait=true ) {
            if ( e is AggregateException ae ) {
                foreach ( var ie in ae.InnerExceptions ) {
                    ShowException( ie, false );
                }
                WaitForKeypress( wait );
                return (int) ErrorCode.Unknown;
            }

            string msg = ( e is CompilerException ) ? e.InnerException?.Message : null;
            if ( (Logger.LogStream?.BaseStream.Position ?? 0) != lastPosition ) Logger.LogMessage( "" ); // new line, log only
            ShowError( $"[{e.GetType().Name}]: {msg ?? e.Message}", wait: false );
            using ( var indent = new Logger.IndentScope() ) {
                var b = e;
                bool once = true;
                while (b.InnerException != null) {
                    b = b.InnerException;
                    msg = ( once && (msg != null) ) ? "" : null;
                    msg = msg ?? $": {b.Message}";
                    once = false;
                    if ( b is System.Reflection.TargetInvocationException ) continue;
                    Logger.LogMessage( $"[{b.GetType().Name}]{msg}" );
                }

                if ( e is CompilerException ) {
                    Logger.LogMessage( "INFO", $"\n{((CompilerException) e).FileName}" );
                    if ( e is MbinException ) {
                        var mbin = ((MbinException) e).Mbin;
                        Logger.LogMessage( "INFO", GetFileInfo( mbin ) );
                    }
                    e = e.InnerException;
                }

                Logger.LogMessage( (e is System.IO.EndOfStreamException) ? "" : $"\n{b.StackTrace}\n" );
            }
            lastPosition = Logger.LogStream?.BaseStream.Position ?? 0;
            WaitForKeypress( wait );
            return (int) ErrorCode.Unknown;
        }

        public static string GetFileInfo( MBINFile mbin ) {
            return $"MBIN\tversion:\t{mbin.Header.GetMBINVersion()}\tguid:\t{mbin.Header.TemplateGUID:X}\ttemplate:\t{mbin.Header.TemplateName}";
        }

        /// <summary>
        /// Display an error message and optionally wait for a key press.
        /// </summary>
        /// <param name="msg">The error message to display.</param>
        /// <param name="showHelp">If true, also calls <see cref="ShowHelp()"/>.</param>
        /// <param name="exitCode">The value to return, unless <paramref name="showHelp"/> is true.</param>
        /// <returns>Returns 1 if <paramref name="showHelp"/> is true, otherwise <paramref name="exitCode"/>.</returns>
        /// <summary>
        public static int ShowError( string msg, ErrorCode code = ErrorCode.Unknown, bool wait = true )
        {
            Logger.LogError( msg );
            WaitForKeypress( wait );
            return (int) code;
        }

        /// <summary>
        /// Display a warning message.
        /// </summary>
        /// <param name="msg">The warning message to display.</param>
        public static void ShowWarning( string msg ) => Logger.LogWarning( msg );

        /// <summary>
        /// Display a command line parsing error message.
        /// <see cref="ShowError(String, Boolean, Int32)"/>
        /// </summary>
        /// <param name="msg">The error message to display.</param>
        /// <returns>ErrorCode.CommandLine</returns>
        public static int ShowCommandLineError( string msg ) => ShowHelp( (ErrorCode) ShowError( msg, ErrorCode.CommandLine, false ) );

        public static int ShowInvalidCommandLineArg( string arg ) => ShowCommandLineError( $"Invalid command line argument: {arg}" );
        public static int ShowInvalidCommandLineArg( CommandLineParser options ) => ShowInvalidCommandLineArg( options.Args[0] );

        /// <summary>
        /// Show the version string.
        /// </summary>
        /// <returns>Always returns 0 (exit code = success)</returns>
        public static int ShowVersion( bool quiet = false ) => ShowVersion( null, quiet );
        public static int ShowVersion( MBINFile mbin , bool quiet = false )
        {
            using ( var forceConsole = new ForceConsoleOutput() ) {
                Logger.LogInfo( Version.GetVersionString( mbin, quiet ) );
            }
            return 0;
        }

        /// <summary>
        /// Display "Press any key" and wait for keypress.
        /// </summary>
        public static void WaitForKeypress( bool wait = true )
        {
            if ( Quiet || !wait || Console.IsOutputRedirected ) return;
            Console.Out.WriteLine( "\nPress any key to continue . . ." );
            Console.ReadKey();
        }

        public static string WrapLine( string txt = null, int padleft = 0, int width = 0 ) {
            if (txt is null) { return ""; }
            width = ( width > 0 ) ? width : Console.BufferWidth;

            // split into lines
            string[] lines = txt.Split( new char[] { '\n' }, StringSplitOptions.None );

            // split each line into words and rebuild wrapped lines with proper indent
            txt = "";
            string padding = new string( ' ', padleft );
            string currentLine = padding;
            foreach(var line in lines ) {
                string[] words = line.Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries );
                foreach (var word in words) {
                    if ((currentLine.Length + 1 + word.Length) >= width) { // flush
                        txt += currentLine + ( !currentLine.EndsWith( "\n" ) ? "\n" : "" );
                        currentLine = padding;
                    }
                    currentLine += ( currentLine.Length > padleft ) ? " " : "";
                    currentLine += word;
                }
                txt += currentLine + ( !currentLine.EndsWith( "\n" ) ? "\n" : "" );
                currentLine = padding;
            }

            return txt;
        }

    }
}
