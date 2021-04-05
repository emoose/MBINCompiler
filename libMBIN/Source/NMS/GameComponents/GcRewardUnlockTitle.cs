using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x0, NameHash = 0xAC19C9A74178EED8)]
    public class GcRewardUnlockTitle : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string titleID;
        /* 0x10 */ public bool NoMusic;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] EndPadding;
    }
}
