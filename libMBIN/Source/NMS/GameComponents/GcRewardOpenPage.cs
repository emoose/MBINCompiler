using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xE2A6F101317157D7, NameHash = 0xF1F483BCEFC0AD13)]
    public class GcRewardOpenPage : NMSTemplate
    {
        // 0x9 entries
		public enum PageToOpenEnum { FreighterShipTransfer, DisplayPortalUa, ExpeditionSelect, TraderInventory, ExpeditionDetails,
            ExpeditionDebrief, BuildingPartsShop, ExocraftShop, NexusTechShop }
		public PageToOpenEnum PageToOpen;
        /* 0x4 */ public bool ReinteractWhenComplete;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] EndPadding;
    }
}
