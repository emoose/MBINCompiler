using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x63, GUID = 0x6419C3C949E87B35, NameHash = 0x63DAFA0869073279)]
    public class GcAtlasFeaturedBaseStateChange : NMSTemplate
    {
        /* 0x000 */ public bool Dev;
        /* 0x001 */ public bool QA;
        /* 0x002 */ public bool Prod;
        [NMS(Size = 0x20)]
        /* 0x003 */ public string Platform;
        [NMS(Size = 0x40)]
        /* 0x023 */ public string BaseId;
    }
}
