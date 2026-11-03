namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA43D335BA955717, NameHash = 0x2680F101)]
    public class GcMissionSequenceWait : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public float Time;
        [NMS(Index = 3)]
        /* 0x14 */ public bool MultiplyTimeBySeasonValue;
        [NMS(Index = 2)]
        /* 0x15 */ public bool SuppressMessages;
    }
}
