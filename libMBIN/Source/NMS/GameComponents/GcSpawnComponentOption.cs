using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x873D9A8B0C56747C, NameHash = 0xA7EE5AECC28F3591)]
    public class GcSpawnComponentOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public GcSeed Seed;
        /* 0x20 */ public GcResourceElement SpecificModel;
    }
}
