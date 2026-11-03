namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F9A5A9A8E69738F, NameHash = 0x6250F740)]
    public class GcMissionSequenceCorvetteAutopilot : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x10 */ public VariableSizeString MessageAutopiloting;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString MessageNotReadyToAutopilot;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString MessageReadyToAutopilot;
        [NMS(Index = 3)]
        /* 0x40 */ public float RequiredAutopilotTime;
        [NMS(Index = 4)]
        /* 0x44 */ public bool TakeTimeFromSeasonData;
    }
}
