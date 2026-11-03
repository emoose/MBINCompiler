namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A20CA93F5DE867A, NameHash = 0xA5334126)]
    public class GcCostHasActiveScanEvent : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OptionalEventID;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Text;
    }
}
