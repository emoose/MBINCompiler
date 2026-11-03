namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC68CF28C2332679, NameHash = 0xE5AFDAD)]
    public class GcMissionConditionHasCommunicatorSignal : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A SpecificSignalID;
        [NMS(Index = 2)]
        /* 0x20 */ public bool CallMustBePending;
        [NMS(Index = 1)]
        /* 0x21 */ public bool SpecificSignalIsCurrentIntervention;
    }
}
