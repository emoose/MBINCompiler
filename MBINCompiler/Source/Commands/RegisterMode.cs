using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using libMBIN;

namespace MBINCompiler.Commands {

    internal class RegisterCommand : Command<RegisterCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            const string name = "PATH";
            string pathvar = System.Environment.GetEnvironmentVariable(name);
            var value = pathvar + ';' + Environment.CurrentDirectory;
            var target = EnvironmentVariableTarget.Machine;
            System.Environment.SetEnvironmentVariable(name, value, target);
            return CommandLine.ShowSuccess();
        }
    }

}
