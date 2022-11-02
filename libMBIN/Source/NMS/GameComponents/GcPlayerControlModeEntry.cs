using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E83155A37FE77D7, NameHash = 0xB40BD8EC092ACF02)]
    public class GcPlayerControlModeEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkModelResource ControlModeResource;
    }
}
