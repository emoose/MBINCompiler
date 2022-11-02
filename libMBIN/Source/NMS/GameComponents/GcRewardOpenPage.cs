namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x881BC20B042BCDC4, NameHash = 0xF1F483BCEFC0AD13)]
    public class GcRewardOpenPage : NMSTemplate
    {
        // size: 0xF
        public enum PageToOpenEnum {
            FreighterShipTransfer,
            DisplayPortalUa,
            ExpeditionSelect,
            TraderInventory,
            ExpeditionDetails,
            ExpeditionDebrief,
            BuildingPartsShop,
            ExocraftShop,
            NexusTechShop,
            ScrapDealerShop,
            BuyShip,
            SettlementManagement,
            SquadronManagement,
            SquadronRecruitment,
            FleetManagement
        }
        /* 0x0 */ public PageToOpenEnum PageToOpen;
        /* 0x4 */ public bool ReinteractWhenComplete;
    }
}
