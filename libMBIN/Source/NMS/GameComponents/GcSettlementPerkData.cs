using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67E5E3EB0EB94E3, NameHash = 0x2217B635)]
    public class GcSettlementPerkData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Description;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Name;
        [NMS(Index = 9)]
        /* 0x40 */ public List<GcBuildingClassification> AssociatedBuildings;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 ID;
        [NMS(Index = 8)]
        /* 0x60 */ public List<GcSettlementStatChange> StatChanges;
        [NMS(Index = 7)]
        /* 0x70 */ public bool IsBlessing;
        [NMS(Index = 6)]
        /* 0x71 */ public bool IsJob;
        [NMS(Index = 3)]
        /* 0x72 */ public bool IsNegative;
        [NMS(Index = 5)]
        /* 0x73 */ public bool IsProc;
        [NMS(Index = 4)]
        /* 0x74 */ public bool IsStarter;
    }
}
