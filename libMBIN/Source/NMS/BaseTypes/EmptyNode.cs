using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS // 0x48
{
    [NMS(Size = 0x48)]
    public class EmptyNode : NMSTemplate
    {
        [NMS(Size = 0x0, Ignore = true)]
        public byte[] Padding;
    }
}