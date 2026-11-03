using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F8533EF2FDD372B, NameHash = 0x56203212)]
    public class GcPlayerControlModeEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource ControlModeResource;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
    }
}
