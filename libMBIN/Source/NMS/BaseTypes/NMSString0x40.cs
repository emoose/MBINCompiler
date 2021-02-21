using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x40, Alignment = 0x1)]
    public class NMSString0x40 : NMSTemplate
    {
        [NMS(Size = 0x40)]
        public string Value;
    }
}
