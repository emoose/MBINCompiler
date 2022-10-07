namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56A9140FCB935C33, NameHash = 0x5FD144DDEE5E5ECF)]
    public class GcCreatureRarity : NMSTemplate
    {
        // size: 0x4
        public enum CreatureRarityEnum {
            Common,
            Uncommon,
            Rare,
            SuperRare
        }
        /* 0x0 */ public CreatureRarityEnum CreatureRarity;
    }
}
