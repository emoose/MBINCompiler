namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x786DE8497EEECF6E, NameHash = 0x541D78BA92E4C104)]
    public class GcWonderTreasureCategory : NMSTemplate
    {
        // size: 0xD
        public enum WonderTreasureCategoryEnum {
            Loot,
            Document,
            BioSample,
            Fossil,
            Plant,
            Tool,
            Farm,
            SeaLoot,
            SeaHorror,
            Salvage,
            Bones,
            SpaceHorror,
            SpaceBones,
        }
        /* 0x0 */ public WonderTreasureCategoryEnum WonderTreasureCategory;
    }
}
