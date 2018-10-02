using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xBE20B8323918D049)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        public GcStatsTypes StatType;
        public bool LessIsBetter;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
