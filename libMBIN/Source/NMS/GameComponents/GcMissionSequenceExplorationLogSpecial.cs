namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2176DCD1B572165, NameHash = 0x5F62735)]
    public class GcMissionSequenceExplorationLogSpecial : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CustomPlanetLog;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A CustomPlanetMessage;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x20A CustomSystemLog;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x20A CustomSystemMessage;
        [NMS(Index = 4)]
        /* 0x80 */ public VariableSizeString DebugText;
    }
}
