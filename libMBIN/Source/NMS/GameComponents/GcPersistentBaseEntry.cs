namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB39E3870A3CBC82, NameHash = 0xD040D4124F0456EF)]
    public class GcPersistentBaseEntry : NMSTemplate
    {
        /* 0x00 */ public ulong Timestamp;
        /* 0x08 */ public NMSString0x10 ObjectID;
        /* 0x18 */ public ulong UserData;
        /* 0x20 */ public Vector3f Position;
        /* 0x30 */ public Vector3f Up;
        /* 0x40 */ public Vector3f At;
        /* 0x50 */ public NMSString0x40 Message;
    }
}
