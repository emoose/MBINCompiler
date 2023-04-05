using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF44E0A7D9BD01F34, NameHash = 0x24D022A0BCD713A0)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Technology;
        /* 0x10 */ public GcStatsTypes TechStat;
        /* 0x14 */ public int RepairedComponents;
        /* 0x18 */ public NMSString0x10 SpecificComponent;
        /* 0x28 */ public bool CountAsRepairIfTechMissing;
    }
}
