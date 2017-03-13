using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcDiscoveryOwner : NMSTemplate // size = 0xC4
    {

        [NMS(Size = 0x40)]
        public string LocalID;
        [NMS(Size = 0x40)]
        public string OnlineID;
        [NMS(Size = 0x40)]
        public string Username;
        public int TimeStamp;
    }
}
