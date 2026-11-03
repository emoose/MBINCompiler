using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D966DB678C65AD2, NameHash = 0x67871D30)]
    public class GcMissionConditionCommunityTeam : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCommunityTeam TeamID;
    }
}
