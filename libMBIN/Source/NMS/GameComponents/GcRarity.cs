namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EC8B7AFAE5265C7, NameHash = 0x66EC10A7)]
    public class GcRarity : NMSTemplate
    {
        // size: 0x3
        public enum RarityEnum : uint {
            Common,
            Uncommon,
            Rare,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RarityEnum Rarity;
    }
}
