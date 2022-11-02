using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F1368C3E04ED55E, NameHash = 0xCBEE12530E8A51CD)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes StatType;
        /* 0x4 */ public bool LessIsBetter;
    }
}
