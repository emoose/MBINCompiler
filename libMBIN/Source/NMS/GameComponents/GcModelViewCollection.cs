using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1080, GUID = 0x3B4CC3DEE46D547D, NameHash = 0xC3362B34D26192B6)]
    public class GcModelViewCollection : NMSTemplate
    {
        public enum ModelViewEnum {
            Inactive, Suit, Weapon, Ship, Vehicle, DiscoveryMain, DiscoveryThumbnail, ToolboxMain, ToolboxThumbnail, TradeSuit,
            TradeShip, TradeCompareShips, TradeCompareWeapons, HUDThumbnail, Interaction, Freighter, TradeFreighter, TradeChest, TradeCapsule, TradeFrigate,
            TerrainBall, FreighterChest, Submarine, TradeCooker
        }
        [NMS(Size = 0x18, EnumType = typeof(ModelViewEnum))]
        public TkModelRendererData[] ModelViews;
    }
}
