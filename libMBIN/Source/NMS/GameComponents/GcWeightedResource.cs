using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x88, GUID = 0xA30463301D9FCBAB, NameHash = 0x701157823082E732)]
    public class GcWeightedResource : NMSTemplate
    {
        /* 0x0 */ public float RelativeProbability;
        /* 0x4 */ public TkModelResource Geometry;
    }
}
