namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7072D0794DC08252, NameHash = 0x3317FE9999913ADE)]
    public class GcBlockedUser : NMSTemplate
    {
        /* 0x00 */ public NMSString0x40 UserId;
        /* 0x40 */ public NMSString0x40 Username;
        /* 0x80 */ public NMSString0x20 Platform;
    }
}
