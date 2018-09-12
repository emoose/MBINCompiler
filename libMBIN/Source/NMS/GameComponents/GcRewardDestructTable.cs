using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0CAF4275C40A91D9C)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 9)]
        public GcRewardDestructRarities[] Categories;
    }
}
