using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompiler.Commands {

    internal class HelpCommand : Command<HelpCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            return CommandLine.ShowHelp();
        }
    }

}
