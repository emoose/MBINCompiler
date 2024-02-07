using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E8D469D98904244, NameHash = 0xC6D3D6561D8622C1)]
    public class GcItemFilterStageDataProductCategory : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A DisabledMessage;
        /* 0x20 */ public GcProductCategory Category;
    }
}
