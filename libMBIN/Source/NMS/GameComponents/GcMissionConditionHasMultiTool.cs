using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBBAA8BC9555C8C8, NameHash = 0xF65D2CFF75A05B47)]
    public class GcMissionConditionHasMultiTool : NMSTemplate
    {
        /* 0x0 */ public GcInventoryClass InventoryClass;
        /* 0x4 */ public bool CheckAllTools;
        /* 0x5 */ public bool BetterClassMatches;
        /* 0x6 */ public bool TakeValueFromSeasonData;
    }
}
