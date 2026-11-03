namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDCF6139EAF78A345, NameHash = 0x3A82D860)]
    public class TkRawID : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong Value0;
        [NMS(Index = 1)]
        /* 0x8 */ public ulong Value1;
    }
}
