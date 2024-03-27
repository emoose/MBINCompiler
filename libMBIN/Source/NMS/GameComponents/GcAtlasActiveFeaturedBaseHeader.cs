namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DB16379E37A198F, NameHash = 0x5CA0B64244DF6963)]
    public class GcAtlasActiveFeaturedBaseHeader : NMSTemplate
    {
        /* 0x000 */ public bool Dev;
        /* 0x001 */ public bool QA;
        /* 0x002 */ public bool Prod;
        /* 0x003 */ public NMSString0x20 Platform;
        /* 0x023 */ public NMSString0x40 UserId;
        /* 0x063 */ public NMSString0x40 UserName;
        /* 0x0A3 */ public NMSString0x40 BaseName;
        /* 0x0E3 */ public NMSString0x40 UA;
        /* 0x123 */ public NMSString0x40 BaseId;
    }
}
