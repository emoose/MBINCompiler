namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0CAF4275C40A91D9C)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 9)]
        public GcRewardDestructRarities[] Categories;
    }
}
