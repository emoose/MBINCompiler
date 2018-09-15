using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0xE66752866A9C2380)]
    public class GcRewardTableItem : NMSTemplate        // size: 0x90
    {
        /* 0x00 */ public float PercentageChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSTemplate Reward;
        [NMS(Size = 0x40)]
        /* 0x50 */ public string LabelID;
    }
}
