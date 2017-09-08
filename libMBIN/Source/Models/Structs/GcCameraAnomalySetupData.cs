namespace libMBIN.Models.Structs
{
    public class GcCameraAnomalySetupData : NMSTemplate     // size: 0x40
    {
        /* 0x00 */ public Vector4f CameraAt;
		/* 0x10 */ public Vector4f CameraUp;
        /* 0x20 */ public Vector4f CameraOffset;
		/* 0x30 */ public Vector4f SunDirection;
    }
}