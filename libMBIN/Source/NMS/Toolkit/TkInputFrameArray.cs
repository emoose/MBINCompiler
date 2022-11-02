using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8103B9F82260D1A7, NameHash = 0xA9237A301B5A6C2F)]
    public class TkInputFrameArray : NMSTemplate
    {
        [NMS(Size = 0x4E20)]
        /* 0x0 */ public TkInputFrame[] Array;
    }
}
