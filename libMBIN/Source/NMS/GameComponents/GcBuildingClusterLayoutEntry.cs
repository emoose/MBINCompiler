using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x14, GUID = 0x76AE2AA37450320F, NameHash = 0x3C79A95C7D8D0B89)]
    public class GcBuildingClusterLayoutEntry : NMSTemplate
    {
        /* 0x00 */ public GcBuildingClassification Building;
        /* 0x04 */ public float Probability;
        /* 0x08 */ public int Min;
        /* 0x0C */ public int Max;
        /* 0x10 */ public bool FacesCentre;
    }
}
