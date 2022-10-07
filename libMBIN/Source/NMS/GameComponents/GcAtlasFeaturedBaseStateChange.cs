namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6419C3C949E87B35, NameHash = 0x63DAFA0869073279)]
    public class GcAtlasFeaturedBaseStateChange : NMSTemplate
    {
        /* 0x00 */ public bool Dev;
        /* 0x01 */ public bool QA;
        /* 0x02 */ public bool Prod;
        /* 0x03 */ public NMSString0x20 Platform;
        /* 0x23 */ public NMSString0x40 BaseId;
    }
}
