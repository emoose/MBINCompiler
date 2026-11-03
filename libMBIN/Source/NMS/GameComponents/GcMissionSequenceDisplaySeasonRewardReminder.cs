namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74E071299795B1DD, NameHash = 0x43B098E5)]
    public class GcMissionSequenceDisplaySeasonRewardReminder : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public float Time;
    }
}
