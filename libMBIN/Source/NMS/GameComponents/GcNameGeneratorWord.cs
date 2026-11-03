namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AEBFA70A00F67D0, NameHash = 0xAFF22D40)]
    public class GcNameGeneratorWord : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Word;
        [NMS(Index = 1)]
        /* 0x20 */ public int NumOptions;
    }
}
