using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcLootComponentData : NMSTemplate
    {
        public Vector2f Timed;
        [NMS(Size = 0x10)]
        public string TimeOutEffect;
        public bool DeathPoint;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding19;
    }
}
