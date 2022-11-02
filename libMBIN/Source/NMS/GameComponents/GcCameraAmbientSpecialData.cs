namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x525A3B0DBFA157D9, NameHash = 0xC266DA7C9BDD51E7)]
    public class GcCameraAmbientSpecialData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Animation;
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        // size: 0x1
        public enum CameraOriginEnum {
            ExternalBase
        }
        /* 0x20 */ public CameraOriginEnum CameraOrigin;
        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;
    }
}
