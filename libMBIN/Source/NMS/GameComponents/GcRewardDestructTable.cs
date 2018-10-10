using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCAF4275C40A91D9C)]
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 7)]     // exe says 9 but the mbin has only room for 7...
        public GcRewardDestructRarities[] Categories;
    }
}
