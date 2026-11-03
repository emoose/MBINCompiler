using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCACC90AB13625036, NameHash = 0xE5550381)]
    public class GcMissionConditionTechGroupCount : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<NMSString0x20A> TechGroups;
        [NMS(Index = 0)]
        /* 0x10 */ public int TargetCount;
        [NMS(Index = 1)]
        /* 0x14 */ public bool TakeCountFromSeasonData;
        [NMS(Index = 3)]
        /* 0x15 */ public bool TestDraftCorvette;
    }
}
