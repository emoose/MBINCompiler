using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD586EEF27450931, NameHash = 0x96215D43)]
    public class GcGameTableDiceResourceData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 3)]
        /* 0x20 */ public List<NMSString0x20A> Descriptors;
        [NMS(Index = 1)]
        /* 0x30 */ public GcFilename Filename;
        [NMS(Index = 2)]
        /* 0x40 */ public GcSeed Seed;
        [NMS(Index = 4)]
        /* 0x50 */ public float Scale;
    }
}
