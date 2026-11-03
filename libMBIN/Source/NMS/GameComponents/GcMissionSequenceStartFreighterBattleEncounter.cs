using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9798FE6B7C49239, NameHash = 0xB8252ACA)]
    public class GcMissionSequenceStartFreighterBattleEncounter : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public GcSpaceBattleType SpaceBattleType;
    }
}
