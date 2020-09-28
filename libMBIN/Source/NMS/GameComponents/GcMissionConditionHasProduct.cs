using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x11845CA9EB0A4CE0, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        /* 0x0 */ public GcDefaultMissionProductEnum Default;
        /* 0x4 */ public GcProductTableEnum Product;
        /* 0x8 */ public int Amount;
        /* 0xC */ public bool ForceSearchFreighterAndChests;
        /* 0xD */ public bool SearchEveryShip;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0xE */ public byte[] EndPadding;
    }
}
