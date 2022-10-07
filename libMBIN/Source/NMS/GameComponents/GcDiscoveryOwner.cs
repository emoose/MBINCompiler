namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6C64C2E515ADAC6, NameHash = 0x59B76FD6543E9F75)]
    public class GcDiscoveryOwner : NMSTemplate
    {
        /* 0x000 */ public NMSString0x40 LocalID;
        /* 0x040 */ public NMSString0x40 OnlineID;
        /* 0x080 */ public NMSString0x40 Username;
        /* 0x0C0 */ public NMSString0x40 Platform;
        /* 0x100 */ public int Timestamp;
    }
}
