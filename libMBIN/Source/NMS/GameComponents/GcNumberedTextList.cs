namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA01A3BEEA71A171, NameHash = 0x53A81775)]
    public class GcNumberedTextList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Format;
        [NMS(Index = 1)]
        /* 0x10 */ public int Count;
    }
}
