using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75F2C9B0CC471CBF, NameHash = 0xDAD32FDD35922F28)]
    public class GcMissionConditionBaseQuery : NMSTemplate
    {
        /* 0x00 */ public GcBaseSearchFilter BaseSearchFilter;
        /* 0x98 */ public int MinBasesFound;
        /* 0x9C */ public int MaxBasesFound;
        /* 0xA0 */ public float SearchDistanceLimit;
        /* 0xA4 */ public bool TakeSpecificPartIdFromSeasonData;
    }
}
