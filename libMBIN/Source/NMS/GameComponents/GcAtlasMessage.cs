using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDC76CC341CDC6F9, NameHash = 0x81E5018BD0B4C94D)]
    public class GcAtlasMessage : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x18 */ public NMSString0x80 CustomName;
        /* 0xA0 */ public Vector3f Position;
        /* 0xB0 */ public int ColourIndex;
    }
}
