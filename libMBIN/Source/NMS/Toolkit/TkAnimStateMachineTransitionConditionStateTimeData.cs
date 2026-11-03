namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA9CFAD73F75543F4, NameHash = 0x5BDF2A2)]
    public class TkAnimStateMachineTransitionConditionStateTimeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float MaxTime;
        [NMS(Index = 0)]
        /* 0x4 */ public float MinTime;
    }
}
