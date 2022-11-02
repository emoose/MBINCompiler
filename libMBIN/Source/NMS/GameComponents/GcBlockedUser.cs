namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85043D8204A321AB, NameHash = 0x3317FE9999913ADE)]
    public class GcBlockedUser : NMSTemplate
    {
        /* 0x00 */ public NMSString0x40 UserId;
        /* 0x40 */ public NMSString0x40 Username;
        /* 0x80 */ public NMSString0x20 Platform;
    }
}
