namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3129A6335CFA4E21, NameHash = 0x1966AFFB10CA6C7C)]
    public class GcMissionConditionUsingThirdPersonCamera : NMSTemplate
    {
        // size: 0x3
        public enum UsingCameraModeEnum {
            OnFoot,
            Ship,
            Vehicle,
        }
        /* 0x0 */ public UsingCameraModeEnum UsingCameraMode;
    }
}
