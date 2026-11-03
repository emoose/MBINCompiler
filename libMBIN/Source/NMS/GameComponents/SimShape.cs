using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DF605217F62630, NameHash = 0xF0DC22E6)]
    public class SimShape : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public List<ShapePoint> ShapePoints;
        [NMS(Index = 1)]
        /* 0x10 */ public int NumSimI;
        [NMS(Index = 2)]
        /* 0x14 */ public int NumSimJ;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x40 Name;
        [NMS(Index = 6)]
        /* 0x58 */ public NMSString0x40 NodeName;
        [NMS(Index = 5)]
        /* 0x98 */ public bool SimPIsInUnwrappedFormat;
        [NMS(Index = 3)]
        /* 0x99 */ public bool WrapI;
        [NMS(Index = 4)]
        /* 0x9A */ public bool WrapJ;
    }
}
