using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6793591DE3B10D2B, NameHash = 0x9A0073340429C464)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Size = 0x1A, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        /* 0x0 */ public GcProceduralProductData[] Table;
    }
}
