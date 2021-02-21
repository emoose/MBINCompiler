using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x100, Alignment = 0x1)]
    public class NMSString0x100 : NMSTemplate
    {
        [NMS(Size = 0x100)]
        public string Value;
    }
}
