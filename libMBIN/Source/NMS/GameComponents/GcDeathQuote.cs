namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBFD19618DB351BD, NameHash = 0xF995C127)]
    public class GcDeathQuote : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x80 QuoteLine1;
        [NMS(Index = 1)]
        /* 0x080 */ public NMSString0x80 QuoteLine2;
        [NMS(Index = 2)]
        /* 0x100 */ public NMSString0x20 Author;
    }
}
