namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1C8EAE0E3253AA9, NameHash = 0x6E2FC13E)]
    public class GcCreatureRarity : NMSTemplate
    {
        // size: 0x4
        public enum CreatureRarityEnum : uint {
            Common,
            Uncommon,
            Rare,
            SuperRare,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureRarityEnum CreatureRarity;
    }
}
