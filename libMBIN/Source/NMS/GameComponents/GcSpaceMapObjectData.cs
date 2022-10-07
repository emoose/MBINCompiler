namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3925BC926E37BEEA, NameHash = 0x47334DD09E6C3FE9)]
    public class GcSpaceMapObjectData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public bool TintModel;
        /* 0x14 */ public float Radius;
        /* 0x18 */ public float DistanceMin;
        /* 0x1C */ public float DistanceRange;
        /* 0x20 */ public float ScaleRange;
        /* 0x24 */ public float ScaleMagnitude;
        /* 0x28 */ public float ScaleMin;
        /* 0x2C */ public bool Orient;
    }
}
