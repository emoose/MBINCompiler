using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x48, Alignment = 0x1)]
    [NMSDescription("This is a \"dummy\" node which is required as HG sometimes seems to have nodes in entity files which contain no data. " +
                    "This class is to allow for these files to be (de)serialized correctly.")]
    public class EmptyNode : NMSTemplate
    {
        [NMS(Size = 0x0, Ignore = true)]
        public byte[] Padding;
    }
}
