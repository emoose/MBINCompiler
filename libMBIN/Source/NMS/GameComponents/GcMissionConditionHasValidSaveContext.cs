using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75460D4BA7B2C286, NameHash = 0x8E2B9959C16C9306)]
    public class GcMissionConditionHasValidSaveContext : NMSTemplate
    {
        /* 0x0 */ public GcSaveContextQuery CurrentContext;
        /* 0x4 */ public GcSaveContextQuery DesiredContext;
    }
}
