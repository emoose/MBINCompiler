using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0DBC5A035A3C5D89D)]
    public class GcOutpostLSystemPair : NMSTemplate // 0x320 bytes
    {
        [NMS(Size = 0x20)]
        public string Locator;
        [NMS(Size = 7)]
        public NMSString0x80[] LSystems;
    }
}
