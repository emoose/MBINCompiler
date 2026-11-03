namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FDA324ACC81B0D3, NameHash = 0x1EE83363)]
    public class GcSpaceBattleFlagshipType : NMSTemplate
    {
        // size: 0x3
        public enum SpaceBattleFlagshipTypeEnum : uint {
            None,
            Freighter,
            AtlasStation,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SpaceBattleFlagshipTypeEnum SpaceBattleFlagshipType;
    }
}
