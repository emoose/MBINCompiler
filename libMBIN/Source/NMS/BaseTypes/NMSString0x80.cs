using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    // todo: maybe get rid of this and just read strings directly into the list, if all strings are the same size?
    public class NMSString0x80 : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Value;
    }
}
