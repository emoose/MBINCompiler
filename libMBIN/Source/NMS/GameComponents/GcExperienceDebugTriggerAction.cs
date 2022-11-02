using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA98C360FD63908A, NameHash = 0x3339FF1DC3ABF146)]
    public class GcExperienceDebugTriggerAction : NMSTemplate
    {
        /* 0x0 */ public GcExperienceDebugTriggerActionTypes Action;
        /* 0x4 */ public int IntParameter;
    }
}
