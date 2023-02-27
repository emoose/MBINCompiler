using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF69424E7FAC4765, NameHash = 0xDC7A747D3350B89B)]
    public class GcMissionSequenceGoToGalacticPoint : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcMissionGalacticPoint Target;
        /* 0x84 */ public NMSString0x80 DebugText;
    }
}
