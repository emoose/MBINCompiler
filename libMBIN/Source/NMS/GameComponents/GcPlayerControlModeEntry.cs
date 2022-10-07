using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A2E0608F3F962B9, NameHash = 0xB40BD8EC092ACF02)]
    public class GcPlayerControlModeEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkModelResource ControlModeResource;
    }
}
