using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x0000000000000000, NameHash = 0x1F78606838C7F310)]
    // Note: This is called "GcDefaulMissionProduct", so I fixed the spelling mistake...
    public class GcDefaultMissionProduct : NMSTemplate
    {
        public GcProductTableEnum Product;
    }
}
