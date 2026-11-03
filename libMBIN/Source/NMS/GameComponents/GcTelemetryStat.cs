namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE73F43630AD4DB, NameHash = 0x2721C06D)]
    public class GcTelemetryStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Type;
        [NMS(Index = 2)]
        /* 0x20 */ public int Value;
    }
}
