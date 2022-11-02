namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6541E6E3B8E260EF, NameHash = 0xDB3D22C1C68F20C3)]
    public class GcTechnologyRarity : NMSTemplate
    {
        // size: 0x7
        public enum TechnologyRarityEnum {
            Normal,
            VeryCommon,
            Common,
            Rare,
            VeryRare,
            Impossible,
            Always
        }
        /* 0x0 */ public TechnologyRarityEnum TechnologyRarity;
    }
}
