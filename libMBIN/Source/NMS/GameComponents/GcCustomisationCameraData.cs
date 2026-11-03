namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2C14D1D026BC49A, NameHash = 0x9F535FED)]
    public class GcCustomisationCameraData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public int InteractionCameraIndex;
        [NMS(Index = 3)]
        /* 0x04 */ public float MaxPitch;
        [NMS(Index = 5)]
        /* 0x08 */ public float MaxYaw;
        [NMS(Index = 2)]
        /* 0x0C */ public float MinPitch;
        [NMS(Index = 4)]
        /* 0x10 */ public float MinYaw;
        [NMS(Index = 1)]
        /* 0x14 */ public NMSString0x20 InteracttionCameraFocusJoint;
    }
}
