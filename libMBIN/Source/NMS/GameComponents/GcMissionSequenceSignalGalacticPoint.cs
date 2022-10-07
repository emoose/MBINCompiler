using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD77B64DA9352885D, NameHash = 0xE9BF52BE754A51E0)]
    public class GcMissionSequenceSignalGalacticPoint : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcMissionGalacticPoint Target;
        /* 0x84 */ public NMSString0x80 DebugText;
    }
}
