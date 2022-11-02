namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xABFE480626D0DA90, NameHash = 0xF3DC604B80A24AD)]
    public class TkInputFrame : NMSTemplate
    {
        /* 0x00 */ public Vector2f LeftStick;
        /* 0x08 */ public Vector2f RightStick;
        /* 0x10 */ public float LeftTrigger;
        /* 0x14 */ public float RightTrigger;
        /* 0x18 */ public short Buttons;
    }
}
