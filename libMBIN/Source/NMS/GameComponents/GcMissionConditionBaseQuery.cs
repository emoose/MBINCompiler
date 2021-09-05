using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xA8, GUID = 0xBEDEE56AB801D1E8, NameHash = 0xDAD32FDD35922F28)]
    public class GcMissionConditionBaseQuery : NMSTemplate
    {
        /* 0x00 */ public GcBaseSearchFilter BaseSearchFilter;
        /* 0x98 */ public int MinBasesFound;
        /* 0x9C */ public int MaxBasesFound;
        /* 0xA0 */ public float SearchDistanceLimit;
    }
}
