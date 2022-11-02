using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9371F4B7CAD40504, NameHash = 0xF676D3AEF2BB991F)]
    public class GcAtlasBase : NMSTemplate
    {
        /* 0x000 */ public NMSString0x200 OpaqueData;
        /* 0x200 */ public GcUniverseAddressData UniverseAddress;
        /* 0x218 */ public NMSString0x80 CustomName;
    }
}
