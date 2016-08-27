using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSpawnAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Event;
    }
}
