using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x764547C9C778C63, NameHash = 0x3BE10A033C0FF378)]
    public class GcAlienMoodMissionOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public GcAlienMood Mood;
    }
}
