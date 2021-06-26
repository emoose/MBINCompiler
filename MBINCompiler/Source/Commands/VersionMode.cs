using System.IO;
using libMBIN;

namespace MBINCompiler.Commands {

    using static CommandLineOptions;

    internal class VersionCommand : Command<VersionCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            var files = options.GetFileParams();
            if ( files.Count == 0 ) return CommandLine.ShowVersion( Quiet );
            if ( files.Count > 1 ) return CommandLine.ShowInvalidCommandLineArg( files[1] );

            var fIn = new FileStream( files[0], FileMode.Open, FileAccess.Read );
            var mbin = new MBINFile( fIn );
            if ( !mbin.Load() || !mbin.Header.IsValid ) {
                return CommandLine.ShowCommandLineError( "Invalid file type.\n" +
                                                         "Only MBIN files can be versioned.\n" +
                                                        $"\"{files[0]}\"" );
            }

            CommandLine.ShowVersion( mbin, Quiet );
            return (int) ErrorCode.Success;
        }

    }

}
