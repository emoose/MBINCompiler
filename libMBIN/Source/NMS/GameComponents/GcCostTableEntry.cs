using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, Alignment = 0x8, GUID = 0x280D4347D75088D9, NameHash = 0x5923C0EE4B9AD427)]
    public class GcCostTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public bool DisplayCost;
        /* 0x11 */ public bool DontCharge;
        /* 0x12 */ public bool HideOptionAndDisplayCostOnly;
        /* 0x13 */ public bool RemoveOptionIfCantAfford;
        /* 0x14 */ public bool MustAffordInCreative;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15 */ public byte[] Padding15;
        /* 0x18 */ public NMSTemplate Cost;
    }
}
