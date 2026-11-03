namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5AA8AE6FE80A15E, NameHash = 0x91C9273B)]
    public class GcMissionSequenceFindPurpleSystem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
    }
}
