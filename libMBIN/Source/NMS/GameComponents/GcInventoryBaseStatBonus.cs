using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5204C4C01793DBAB)]
    public class GcInventoryBaseStatBonus : NMSTemplate     // size: 0x8
    {
        public GcStatsTypes StatType;
        public bool LessIsBetter;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
