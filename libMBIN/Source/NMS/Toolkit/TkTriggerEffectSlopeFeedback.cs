namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAE36D3248D63376D, NameHash = 0x3B743B8B)]
    public class TkTriggerEffectSlopeFeedback : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float EndPosition;
        [NMS(Index = 3)]
        /* 0x4 */ public float EndStrength;
        [NMS(Index = 0)]
        /* 0x8 */ public float StartPosition;
        [NMS(Index = 1)]
        /* 0xC */ public float StartStrength;
    }
}
