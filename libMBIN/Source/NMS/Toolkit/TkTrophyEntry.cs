namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA2014717593869BC, NameHash = 0x51D536C649733342)]
    public class TkTrophyEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TrophyId;
        /* 0x10 */ public int Ps4Id;
        /* 0x14 */ public NMSString0x40 PCId;
        /* 0x54 */ public NMSString0x20 XboxOneId;
    }
}
