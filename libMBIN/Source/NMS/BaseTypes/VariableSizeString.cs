using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x1)]
    public class VariableSizeString : NMSTemplate
    {
        public string Value;
    }
}
