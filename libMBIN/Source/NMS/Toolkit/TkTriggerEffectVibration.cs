namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB7E67FAD6C11C129, NameHash = 0x2442AEC)]
    public class TkTriggerEffectVibration : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float Frequency;
        [NMS(Index = 0)]
        /* 0x4 */ public float Position;
        [NMS(Index = 1)]
        /* 0x8 */ public float Strength;
    }
}
