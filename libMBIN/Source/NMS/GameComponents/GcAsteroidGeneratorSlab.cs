using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x973E87BA87F7C61A, NameHash = 0xA7877CF3CA740744)]
    public class GcAsteroidGeneratorSlab : NMSTemplate
    {
        /* 0x00 */ public GcAsteroidGeneratorAssignment Assignment;
        /* 0x50 */ public Vector3f Rotation;
        /* 0x60 */ public Vector3f Scale;
        /* 0x70 */ public float NoiseOffset;
        /* 0x74 */ public float NoiseScale;
        /* 0x78 */ public float NoiseApply;
    }
}
