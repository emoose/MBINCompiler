using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC36D53364E03A35, NameHash = 0x4837448F)]
    public class GcBuildingClusterLayoutEntry : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public int Max;
        [NMS(Index = 2)]
        /* 0x4 */ public int Min;
        [NMS(Index = 1)]
        /* 0x8 */ public float Probability;
        [NMS(Index = 0)]
        /* 0xC */ public GcBuildingClassification Building;
        [NMS(Index = 4)]
        /* 0xD */ public bool FacesCentre;
    }
}
