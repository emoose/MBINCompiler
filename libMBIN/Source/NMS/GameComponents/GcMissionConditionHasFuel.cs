using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF93CC6B847898CE4, NameHash = 0x2A8282CD4FA96596)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes TargetStat;
        /* 0x04 */ public int Amount;
        /* 0x08 */ public NMSString0x10 SpecificTechID;
        /* 0x18 */ public bool FormatTextAsPercentage;
    }
}
