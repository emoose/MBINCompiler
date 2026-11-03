namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8267A7F221F48E21, NameHash = 0xA75F7182)]
    public class TkTriggerEffectWeapon : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float EndPosition;
        [NMS(Index = 0)]
        /* 0x4 */ public float StartPosition;
        [NMS(Index = 2)]
        /* 0x8 */ public float Strength;
    }
}
