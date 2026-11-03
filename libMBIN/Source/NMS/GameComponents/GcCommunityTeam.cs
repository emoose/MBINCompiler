namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9427A75C896E6745, NameHash = 0x902B9D5)]
    public class GcCommunityTeam : NMSTemplate
    {
        // size: 0x3
        public enum CommunityTeamEnum : byte {
            Red,
            Green,
            Blue,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CommunityTeamEnum CommunityTeam;
    }
}
