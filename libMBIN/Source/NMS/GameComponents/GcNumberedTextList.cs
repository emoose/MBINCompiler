using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0DF284C3967A7FFBC)]
    public class GcNumberedTextList : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Format;
        public int Count;
    }
}
