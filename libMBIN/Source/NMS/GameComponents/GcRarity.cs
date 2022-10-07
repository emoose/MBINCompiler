namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x254FD01AB6B98C6A, NameHash = 0x85BD8B90D73C1D42)]
    public class GcRarity : NMSTemplate
    {
        // size: 0x3
        public enum RarityEnum {
            Common,
            Uncommon,
            Rare
        }
        /* 0x0 */ public RarityEnum Rarity;
    }
}
