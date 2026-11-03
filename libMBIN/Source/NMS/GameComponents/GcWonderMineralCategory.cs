namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFF1F4E8F4B877EC, NameHash = 0x34C07963)]
    public class GcWonderMineralCategory : NMSTemplate
    {
        // size: 0x8
        public enum WonderMineralCategoryEnum : uint {
            GeneralFact0,
            GeneralFact1,
            GeneralFact2,
            MetalFact,
            ColdFact,
            HotFact,
            RadFact,
            ToxFact,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderMineralCategoryEnum WonderMineralCategory;
    }
}
