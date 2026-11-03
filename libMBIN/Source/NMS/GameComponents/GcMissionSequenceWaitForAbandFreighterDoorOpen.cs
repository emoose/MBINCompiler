namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA096CE6850D9409, NameHash = 0xCB1AFECA)]
    public class GcMissionSequenceWaitForAbandFreighterDoorOpen : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString MessageOvertime;
        [NMS(Index = 2)]
        /* 0x30 */ public float MinTime;
    }
}
