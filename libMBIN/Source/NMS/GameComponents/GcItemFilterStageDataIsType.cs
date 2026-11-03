using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA87C6FA338E6CA0, NameHash = 0x52E946AD)]
    public class GcItemFilterStageDataIsType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A DisabledMessage;
        [NMS(Index = 1)]
        /* 0x20 */ public GcInventoryType Type;
    }
}
