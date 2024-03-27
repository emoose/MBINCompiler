using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7CAB1A3FFC0C6D8, NameHash = 0x30EC4D451DF033BE)]
    public class GcMissionConditionCheckScanEventMissionState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public GcInteractionMissionState RequiredState;
        /* 0x24 */ public bool AlsoAcceptMaintenanceDone;
    }
}
