using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPerformanceFlyby : NMSTemplate       // size: 0x18       in global??
    {
        public float Length;            // 44FA0000h
        public float Offset;            // 43480000h
        public bool Locked;             // 0
        public float LockedOffset;      // 42C80000h
        public float LockTime;          // 40A00000h
        public float LockSpeed;         // 3F000000h
    }
}
