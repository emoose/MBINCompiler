namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x967C9ED766245BC, NameHash = 0x8F486696)]
    public class GcBlockedUser : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x40 UserId;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x40 Username;
        [NMS(Index = 2)]
        /* 0x80 */ public NMSString0x20 Platform;
    }
}
