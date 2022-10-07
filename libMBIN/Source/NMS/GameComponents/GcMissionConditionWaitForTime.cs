namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72DA95320234507C, NameHash = 0x9387E17DE22981F4)]
    public class GcMissionConditionWaitForTime : NMSTemplate
    {
        /* 0x0 */ public ulong WaitTimeInSeconds;
        /* 0x8 */ public bool ThisConditionWillSetMissionUserDataIsThatOk;
    }
}
