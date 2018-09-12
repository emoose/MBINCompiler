using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x79E540957090F638)]
    public class GcRefinerRecipeElement : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcInventoryType Type;
        public int Amount;
    }
}
