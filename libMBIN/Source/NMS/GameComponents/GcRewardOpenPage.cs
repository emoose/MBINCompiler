namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x8, GUID = 0x9EEEC8CD1EAE84D2)]
    public class GcRewardOpenPage : NMSTemplate
    {
		public enum PageToOpenEnum { FreighterShipTransfer, DisplayPortalUa, ExpeditionSelect, TraderInventory, ExpeditionDetails, ExpeditionDebrief, FreeFreighterReward, BuildingPartsShop }
		public PageToOpenEnum PageToOpen;
        /* 0x4 */ public bool ReinteractWhenComplete;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] Endpadding;
    }
}
