using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36C6DCAF9885E4DA, NameHash = 0x223C08FAB30D9754)]
    public class GcWonderRecordCustomData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x200 CustomName;
        /* 0x200 */ public GcWonderType ActualType;
    }
}
