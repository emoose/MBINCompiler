namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56EC8F2FD8FE9316, NameHash = 0xC7374EF3)]
    public class GcMissionSequenceSummonNexus : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public bool IgnorePlanetRadiusAndForceSpawn;
    }
}
