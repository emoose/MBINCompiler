using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x7773BFB15E394873, NameHash = 0xA8C5FB6413CFB7AA)]
    public class GcRewardRefreshHazProt : NMSTemplate
    {
        public float Amount;
        public bool SetNotAdd;
    }
}