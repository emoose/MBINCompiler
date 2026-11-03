using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC194CF0F54BD45C7, NameHash = 0xD9D02175)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFrigateClass Class;
        [NMS(Index = 1)]
        /* 0x4 */ public int RequiredAmount;
    }
}
