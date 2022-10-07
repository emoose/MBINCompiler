using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDD354EFDC27E555, NameHash = 0xE2B8850DAEBB8F74)]
    public class TkModelRendererCameraData : NMSTemplate
    {
        /* 0x00 */ public float Distance;
        /* 0x10 */ public Vector3f Offset;
        /* 0x20 */ public float Roll;
        /* 0x24 */ public float Pitch;
        /* 0x28 */ public float Rotate;
        /* 0x2C */ public float LightPitch;
        /* 0x30 */ public float LightRotate;
        /* 0x34 */ public TkCameraWanderData Wander;
    }
}
