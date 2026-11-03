namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9C8190059A0637B, NameHash = 0xE83447E4)]
    public class GcMissionConditionUsingThirdPersonCamera : NMSTemplate
    {
        // size: 0x3
        public enum UsingCameraModeEnum : uint {
            OnFoot,
            Ship,
            Vehicle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public UsingCameraModeEnum UsingCameraMode;
    }
}
