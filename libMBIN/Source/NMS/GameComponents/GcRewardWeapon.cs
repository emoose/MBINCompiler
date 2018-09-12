namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x14, GUID = 0x0FF1A0BCD4F36D412)]
    public class GcRewardWeapon : NMSTemplate
    {
        public GcRarity Rarity;
        public int ItemLevel;
        public int AmountMin;
        public int AmountMax;
        public bool MarkInteractionComplete;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
