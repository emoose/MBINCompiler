namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD21CEC3776CBB801, NameHash = 0xEBD25F53C92AC4C7)]
    public class GcTelemetryStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 Type;
        /* 0x20 */ public int Value;
    }
}
