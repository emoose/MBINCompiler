using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BB9A196003ACF12, NameHash = 0x25696B35BE341F6C)]
    public class GcMissionSequenceWaitForRefuel : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcStatsTypes TargetStat;
        /* 0x84 */ public int Amount;
        /* 0x88 */ public NMSString0x80 DebugText;
    }
}
