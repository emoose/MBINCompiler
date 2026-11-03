namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10BECC363D1D878E, NameHash = 0x2940D0CB)]
    public class GcCameraAmbientSpecialData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Animation;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        // size: 0x1
        public enum CameraOriginEnum : uint {
            ExternalBase,
        }
        [NMS(Index = 2)]
        /* 0x20 */ public CameraOriginEnum CameraOrigin;
        [NMS(Index = 4)]
        /* 0x24 */ public bool AvoidTerrain;
        [NMS(Index = 3)]
        /* 0x25 */ public bool UseLookAt;
    }
}
