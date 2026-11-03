namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x26559CBC759F3C6B, NameHash = 0x3E6C66E1)]
    public class TkTriggerEffectMultiplePositionVibration : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xA)]
        /* 0x00 */ public float[] Strength;
        [NMS(Index = 0)]
        /* 0x28 */ public float Frequency;
    }
}
