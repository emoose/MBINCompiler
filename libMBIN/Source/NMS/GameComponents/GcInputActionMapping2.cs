namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD0AE47F9FDBCEE, NameHash = 0x6F8BC0CA)]
    public class GcInputActionMapping2 : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x40 Action;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x20 ActionSet;
        [NMS(Index = 3)]
        /* 0x60 */ public NMSString0x20 Axis;
        [NMS(Index = 2)]
        /* 0x80 */ public NMSString0x20 Button;
    }
}
