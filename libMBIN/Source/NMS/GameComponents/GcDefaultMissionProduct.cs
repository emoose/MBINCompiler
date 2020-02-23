using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCB7BB20B2DF0C75E, NameHash = 0x1F78606838C7F310)]
    // Note: This is called "GcDefaulMissionProduct", so I fixed the spelling mistake...
    public class GcDefaultMissionProduct : NMSTemplate
    {
        public GcProductTableEnum Product;
    }
}
