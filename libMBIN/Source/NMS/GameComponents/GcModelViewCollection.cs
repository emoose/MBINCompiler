using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1290, GUID = 0x20F0E57D6D7234CA, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        public enum ModelViewEnum {
            Suit, Weapon, Ship, Vehicle, DiscoveryMain, DiscoveryThumbnail, ToolboxMain, ToolboxThumbnail, TradeSuit,
            TradeShip, TradeCompareShips, TradeCompareWeapons, HUDThumbnail, Interaction, Freighter, TradeFreighter, TradeChest, TradeCapsule, TradeFrigate,
            TerrainBall, FreighterChest, Submarine, TradeCooker, SuitRefiner, FreighterRepair, DiscoveryPlanetaryMapping, Mech
        }
        [NMS(Size = 0x1B, EnumType = typeof(ModelViewEnum))]
        public TkModelRendererData[] ModelViews;
    }
}
