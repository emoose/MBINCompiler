using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libMBIN;

namespace MBINCompiler.Commands {

    internal class ListCommand : Command<ListCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            int noGUID = 0;
            int noSize = 0;

            Logger.LogOutput( "NOTE: the sizes listed are from the NMSAttribute. They are not calculated.\n" );

            foreach ( var type in typeof( NMSTemplate ).Assembly.DefinedTypes) {
                if ( type.BaseType != typeof( NMSTemplate ) ) continue;
                if ( !type.Namespace.StartsWith( "libMBIN.NMS" ) ) continue; // ignore any types not in libMBIN.NMS
                if ( type.Namespace == "libMBIN.NMS" ) continue; // ignore direct descendants of libMBIN.NMS (BaseTypes)

                var attributes = type.GetCustomAttributes( typeof( NMSAttribute ), false );
                if ( (attributes == null) || (attributes.Length == 0) ) {
                    throw new CompilerException( $"{type.FullName}: No NMSAttribute!" );
                }

                var nms = (NMSAttribute) attributes[0];
                var guid = nms.GUID;
                var size = nms.Size;
                var broken = nms.Broken;

                noGUID += (guid == 0) ? 1 : 0;
                noSize += (size == 0) ? 1 : 0;

                Logger.LogInfo( "0x{0:X16}\t0x{1,-8:X}\t{2}{3}", guid, size, type.Name, broken ? "\tBROKEN" : "" );
            }

            if ((noGUID > 0) || (noSize > 0)) {
                Logger.LogOutput( "" ); // new line
                if (noGUID > 0) Logger.LogWarning( $"{noGUID} structs are missing a GUID." );
                if (noSize > 0) Logger.LogWarning( $"{noSize} structs do not have a defined size." );
            }

            return (int) ErrorCode.Success;
        }
    }

}
