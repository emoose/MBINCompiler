using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C4842598A0DA6B8, NameHash = 0xCBEE12530E8A51CD)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes StatType;
        /* 0x4 */ public bool LessIsBetter;
    }
}
