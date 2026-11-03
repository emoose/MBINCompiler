namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1186E197083AF651, NameHash = 0xCD623CE3)]
    public class TkTriggerEffectFeedback : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Position;
        [NMS(Index = 1)]
        /* 0x4 */ public float Strength;
    }
}
