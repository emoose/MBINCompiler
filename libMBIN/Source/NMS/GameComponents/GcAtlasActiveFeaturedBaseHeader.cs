using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x163, GUID = 0x0A383984B7DBD6058, NameHash = 0x5CA0B64244DF6963)]
    public class GcAtlasActiveFeaturedBaseHeader : NMSTemplate
    {
        /* 0x000 */ public bool Dev;
        /* 0x001 */ public bool QA;
        /* 0x002 */ public bool Prod;
        [NMS(Size = 0x20)]
        /* 0x003 */ public string Platform;
        [NMS(Size = 0x40)]
        /* 0x023 */ public string UserId;
        [NMS(Size = 0x40)]
        /* 0x063 */ public string UserName;
        [NMS(Size = 0x40)]
        /* 0x0A3 */ public string BaseName;
        [NMS(Size = 0x40)]
        /* 0x0E3 */ public string UA;
        [NMS(Size = 0x40)]
        /* 0x123 */ public string BaseId;
    }
}
