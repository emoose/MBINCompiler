namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1F0EFF18817E2E8, NameHash = 0x50A80E365BD08E24)]
    public class GcCustomisationCameraData : NMSTemplate
    {
        /* 0x00 */ public int InteractionCameraIndex;
        /* 0x04 */ public NMSString0x20 InteracttionCameraFocusJoint;
        /* 0x24 */ public float MinPitch;
        /* 0x28 */ public float MaxPitch;
        /* 0x2C */ public float MinYaw;
        /* 0x30 */ public float MaxYaw;
    }
}
