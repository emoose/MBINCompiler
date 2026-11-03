namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3F9281D88F7982C, NameHash = 0xF3D747D8)]
    public class GcInWorldUIScreenData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f ScreenOffset;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector4f ScreenRotation;
        [NMS(Index = 0)]
        /* 0x20 */ public float ScreenScale;
    }
}
