using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBAC848E1676C2DE, NameHash = 0x69CCBDF4)]
    public class GcExpeditionCategoryStrength : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum), MxmlName = "Occurrance Chance")]
        /* 0x0 */ public int[] OccurranceChance;
    }
}
