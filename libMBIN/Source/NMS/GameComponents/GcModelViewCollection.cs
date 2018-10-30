using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF20, GUID = 0x6A9F50D8D5D8E024)]
    public class GcModelViewCollection : NMSTemplate
    {
        [NMS(Size = 0x16, EnumValue = new string[0x16] { "Suit", "Weapon", "Ship", "Vehicle", "DiscoveryMain", "DiscoveryThumbnail", "ToolboxMain",
            "ToolboxThumbnail", "TradeSuit", "TradeShip", "TradeCompareShips", "TradeCompareWeapons", "HUDThumbnail", "Interaction", "Freighter",
            "TradeFreighter", "TradeChest", "TradeCapsule", "TradeFrigate", "TerrainBall", "FreighterChest", "Submarine" })]
        public TkModelRendererData[] ModelViews;
    }
}
