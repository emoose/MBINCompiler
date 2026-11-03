namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8841A293DD9B5F05, NameHash = 0xCE31A5B9)]
    public class GcBaseBuildingCameraMode : NMSTemplate
    {
        // size: 0x4
        public enum BaseBuildingCameraModeEnum : uint {
            Inactive,
            FreeCam,
            FocusCam,
            OrbitCam,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseBuildingCameraModeEnum BaseBuildingCameraMode;
    }
}
