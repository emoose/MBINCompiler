using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE70, GUID = 0xED7005EA41AD765D)]
    public class GcModelViewCollection : NMSTemplate
    {
        [NMS(Size = 0x15, EnumValue = new string[0x15] { "Suit", "Weapon", "Ship", "Vehicle", "DiscoveryMain", "DiscoveryThumbnail", "ToolboxMain", "ToolboxThumbnail", "TradeSuit", "TradeShip", "TradeCompareShips", "TradeCompareWeapons", "HUDThumbnail", "Interaction", "Freighter", "TradeFreighter", "TradeChest", "TradeCapsule", "TradeFrigate", "TerrainBall", "FreighterChest" })]
        public TkModelRendererData[] ModelViews;
    }
}
