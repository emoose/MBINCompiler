using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x80, Alignment = 0x1)]
    public class NMSString0x80 : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Value;
    }
}
