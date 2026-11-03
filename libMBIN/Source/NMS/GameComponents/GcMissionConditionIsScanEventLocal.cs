namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B5E866EC6E4E735, NameHash = 0x4F937484)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 2)]
        /* 0x20 */ public bool BlockMissionRestart;
        [NMS(Index = 1)]
        /* 0x21 */ public bool RequiresFullFireteam;
    }
}
