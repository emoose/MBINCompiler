using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE60A19074D275D92, NameHash = 0xE2FBC00AA319096D)]
    public class GcMissionSequenceSetGlobalMission : NMSTemplate
    {
        /* 0x0 */ public GcRewardChangeGlobalMission Type;
        /* 0x4 */ public NMSString0x80 DebugText;
    }
}
