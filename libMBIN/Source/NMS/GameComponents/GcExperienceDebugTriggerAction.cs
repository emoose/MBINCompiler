using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E90373863419BF0, NameHash = 0x3339FF1DC3ABF146)]
    public class GcExperienceDebugTriggerAction : NMSTemplate
    {
        /* 0x0 */ public GcExperienceDebugTriggerActionTypes Action;
        /* 0x4 */ public int IntParameter;
    }
}
