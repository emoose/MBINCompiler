using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x1AA7298C571A8A12, NameHash = 0xCBEE12530E8A51CD)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        public GcStatsTypes StatType;
        public bool LessIsBetter;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
