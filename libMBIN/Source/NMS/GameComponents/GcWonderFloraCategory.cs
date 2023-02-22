namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FABE5DB17A678A5, NameHash = 0x5AC5BEA036002DC)]
    public class GcWonderFloraCategory : NMSTemplate
    {
        // size: 0x8
        public enum WonderFloraCategoryEnum {
            GeneralFact0,
            GeneralFact1,
            GeneralFact2,
            GeneralFact3,
            ColdFact,
            HotFact,
            RadFact,
            ToxFact,
        }
        /* 0x0 */ public WonderFloraCategoryEnum WonderFloraCategory;
    }
}
