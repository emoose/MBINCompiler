namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A81031AE53EE51A, NameHash = 0x9F7E9E78)]
    public class GcWonderFloraCategory : NMSTemplate
    {
        // size: 0x8
        public enum WonderFloraCategoryEnum : uint {
            GeneralFact0,
            GeneralFact1,
            GeneralFact2,
            GeneralFact3,
            ColdFact,
            HotFact,
            RadFact,
            ToxFact,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderFloraCategoryEnum WonderFloraCategory;
    }
}
