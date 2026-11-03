using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x698479FDBFA8A0A7, NameHash = 0x1890966F)]
    public class GcWeightedResource : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource Geometry;
        [NMS(Index = 0, MxmlName = "Relative Probability")]
        /* 0x20 */ public float RelativeProbability;
    }
}
