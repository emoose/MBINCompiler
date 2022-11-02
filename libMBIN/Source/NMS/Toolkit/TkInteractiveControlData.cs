namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB2B037E62CCF173E, NameHash = 0xF6987FC027F7291)]
    public class TkInteractiveControlData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Id;
        /* 0x20 */ public NMSString0x10 RewardId;
        /* 0x30 */ public float Cooldown;
    }
}
