using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2D6CFE36EBA6851, NameHash = 0xCBEE12530E8A51CD)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes StatType;
        /* 0x4 */ public bool LessIsBetter;
    }
}
