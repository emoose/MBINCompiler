namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x917B2B13AC1A63F8, NameHash = 0x468B48C2)]
    public class GcCameraShakeCapturedData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float ShakeFrequency;
        [NMS(Index = 1)]
        /* 0x04 */ public float ShakeStrength;
        [NMS(Index = 4)]
        /* 0x08 */ public float VibrateFrequency;
        [NMS(Index = 3)]
        /* 0x0C */ public float VibrateStrength;
        [NMS(Index = 0)]
        /* 0x10 */ public bool Active;
    }
}
