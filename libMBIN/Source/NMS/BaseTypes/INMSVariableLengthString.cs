using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    public interface INMSVariableLengthString: INMSString
    {
        string String { get; set; }
    }
}
