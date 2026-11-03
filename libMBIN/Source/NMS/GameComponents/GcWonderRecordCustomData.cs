using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22164E6CBD9C1FEA, NameHash = 0x89EAA22E)]
    public class GcWonderRecordCustomData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcWonderType ActualType;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x40 CustomName;
    }
}
