using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F4D8FF55FC80312, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        // size: 0x21
        public enum ModelViewsEnum {
            Suit,
            Weapon,
            Ship,
            Vehicle,
            DiscoveryMain,
            DiscoveryThumbnail,
            ToolboxMain,
            ToolboxThumbnail,
            TradeSuit,
            TradeShip,
            TradeCompareShips,
            TradeCompareWeapons,
            HUDThumbnail,
            Interaction,
            Freighter,
            TradeFreighter,
            TradeChest,
            TradeCapsule,
            TradeFrigate,
            TerrainBall,
            FreighterChest,
            Submarine,
            TradeCooker,
            SuitRefiner,
            FreighterRepair,
            DiscoveryPlanetaryMapping,
            Mech,
            PetThumbnail,
            PetThumbnailUI,
            PetLarge,
            SquadronPilotLarge,
            SquadronPilotThumbnail,
            SquadronSpaceshipThumbnail
        }
        [NMS(Size = 0x21, EnumType = typeof(ModelViewsEnum))]
        /* 0x0 */ public TkModelRendererData[] ModelViews;
    }
}
