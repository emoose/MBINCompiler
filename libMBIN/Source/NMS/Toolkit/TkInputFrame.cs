namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC90A8A8B79EC6C27, NameHash = 0x4ABF284A)]
    public class TkInputFrame : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector2f LeftStick;
        [NMS(Index = 1)]
        /* 0x08 */ public Vector2f RightStick;
        [NMS(Index = 2)]
        /* 0x10 */ public float LeftTrigger;
        [NMS(Index = 3)]
        /* 0x14 */ public float RightTrigger;
        [NMS(Index = 4)]
        /* 0x18 */ public short Buttons;
    }
}
