using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5AA873FA6AFC8E71, NameHash = 0x66AC41FB)]
    public class TkTestBitFieldEnum : NMSTemplate
    {
        // size: 0x5
        [Flags]
        public enum EnumEnum : uint {
            None = 0x0,
            First = 0x1,
            Second = 0x2,
            Third = 0x4,
            Fourth = 0x8,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public EnumEnum Enum;
    }
}
