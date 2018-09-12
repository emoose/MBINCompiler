namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F76E52C52365A783)]
    public class GcRewardSpecificProductRecipe : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public bool Slient;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
