namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2CD161BDDF7BBD4, NameHash = 0xA66A9F625C0BD43C)]
    public class GcExpeditionCategoryStrength : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x0 */ public int[] OccurranceChance;
    }
}
