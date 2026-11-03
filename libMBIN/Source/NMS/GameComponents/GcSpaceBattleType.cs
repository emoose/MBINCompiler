namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AAC25B133B0D532, NameHash = 0x570EB778)]
    public class GcSpaceBattleType : NMSTemplate
    {
        // size: 0x7
        public enum SpaceBattleTypeEnum : uint {
            None,
            PirateShipsEasy,
            PirateShipsStandard,
            PirateShipsHard,
            PirateFreighter,
            SwarmHiveAtlasScripted,
            SwarmHiveAtlas,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpaceBattleTypeEnum SpaceBattleType;
    }
}
