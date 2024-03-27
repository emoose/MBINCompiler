namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DF76DF2866CC002, NameHash = 0x2977C8E531764A2C)]
    public class GcMissionConditionHasCommunicatorSignal : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SpecificSignalID;
        /* 0x20 */ public bool SpecificSignalIsCurrentIntervention;
        /* 0x21 */ public bool CallMustBePending;
    }
}
