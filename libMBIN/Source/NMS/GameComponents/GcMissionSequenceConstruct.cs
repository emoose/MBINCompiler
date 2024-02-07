using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EDABF4875942867, NameHash = 0x694A21AA8BC8BAD4)]
    public class GcMissionSequenceConstruct : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageOutsideBase;
        /* 0x100 */ public NMSString0x80 MessageNoBaseInSystem;
        /* 0x180 */ public NMSString0x80 MessageNoBaseInSystemAndNoStation;
        /* 0x200 */ public NMSString0x80 MessageInNexusAndNeedParts;
        /* 0x280 */ public NMSString0x20A NexusNeedPartsScanEvent;
        /* 0x2A0 */ public NMSString0x20A NoBaseInSystemScanEvent;
        /* 0x2C0 */ public bool HideCompletedPartsOutOfBase;
        /* 0x2C1 */ public bool HideOtherPartsWhenBuyingBlueprints;
        /* 0x2C4 */ public int NumUniquePartsRequired;
        /* 0x2C8 */ public List<GcConstructionPart> PotentialParts;
        /* 0x2D8 */ public List<GcConstructionPartGroup> PotentialPartGroups;
        /* 0x2E8 */ public GcBuildingPartSearchType Type;
        /* 0x308 */ public bool OnlyPickFromKnown;
        /* 0x309 */ public bool ShuffleParts;
        /* 0x30A */ public NMSString0x80 DebugText;
    }
}
