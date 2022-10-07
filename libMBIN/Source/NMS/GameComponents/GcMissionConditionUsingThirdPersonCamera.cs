namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5993895CC7D60EEA, NameHash = 0x1966AFFB10CA6C7C)]
    public class GcMissionConditionUsingThirdPersonCamera : NMSTemplate
    {
        // size: 0x3
        public enum UsingCameraModeEnum {
            OnFoot,
            Ship,
            Vehicle
        }
        /* 0x0 */ public UsingCameraModeEnum UsingCameraMode;
    }
}
