using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x1)]
    public class NMSString0x10 : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Value;
    }
}
