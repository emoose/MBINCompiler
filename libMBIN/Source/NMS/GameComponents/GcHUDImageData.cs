using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x820765B29553ADDD, NameHash = 0xD08C5A93AECF92B1)]
    public class GcHUDImageData : NMSTemplate
    {
        /* 0x00 */ public GcHUDComponent Data;
        /* 0x28 */ public NMSString0x80 Image;
        /* 0xB0 */ public Colour Colour;
    }
}
