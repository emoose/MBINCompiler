using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DF1F0AED684E465, NameHash = 0x543210B019526A44)]
    public class GcBreakTechByStatData : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes DamageTechWithStat;
        /* 0x4 */ public bool IncludeStatChildren;
    }
}
