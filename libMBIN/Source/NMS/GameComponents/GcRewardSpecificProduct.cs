using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x28, GUID = 0x44FE10AEC1800BBD, NameHash = 0x691B32769ECE3BC6)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;
        /* 0x18 */ public int AmountMin;
        /* 0x1C */ public int AmountMax;
        /* 0x20 */ public bool ForceSpecialMessage;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] EndPadding;
    }
}
