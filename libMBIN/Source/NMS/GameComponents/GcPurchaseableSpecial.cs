using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDE2AA34A3D601D23, Size = 0x18)]
    public class GcPurchaseableSpecial : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        public int ShopNumber;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
