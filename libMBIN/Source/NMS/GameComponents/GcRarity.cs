namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC60AFAD86588E41A, NameHash = 0x85BD8B90D73C1D42)]
    public class GcRarity : NMSTemplate
    {
        // size: 0x3
        public enum RarityEnum {
            Common,
            Uncommon,
            Rare,
        }
        /* 0x0 */ public RarityEnum Rarity;
    }
}
