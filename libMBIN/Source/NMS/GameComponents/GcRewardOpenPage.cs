using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xE49C617BF2B8F40E, NameHash = 0xF1F483BCEFC0AD13)]
    public class GcRewardOpenPage : NMSTemplate
    {
        // size: 0xC
		public enum PageToOpenEnum {
            FreighterShipTransfer, DisplayPortalUa, ExpeditionSelect, TraderInventory, ExpeditionDetails, ExpeditionDebrief, BuildingPartsShop, ExocraftShop, NexusTechShop, ScrapDealerShop,
            BuyShip, SettlementManagement
        }
		public PageToOpenEnum PageToOpen;
        /* 0x4 */ public bool ReinteractWhenComplete;
    }
}
