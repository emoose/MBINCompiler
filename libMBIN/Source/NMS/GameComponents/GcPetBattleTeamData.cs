using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF98E1542111C1CC4, NameHash = 0x373109DE)]
    public class GcPetBattleTeamData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3)]
        /* 0x0 */ public GcPetBattleTeamMemberData[] TeamMembers;
    }
}
