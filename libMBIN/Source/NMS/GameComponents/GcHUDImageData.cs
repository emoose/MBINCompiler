using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x10, GUID = 0x820765B29553ADDD)]
    public class GcHUDImageData : NMSTemplate
    {
        public GcHUDComponent Data;

        [NMS(Size = 0x80)]
        public string Image;

        public Colour Colour;
    }
}
