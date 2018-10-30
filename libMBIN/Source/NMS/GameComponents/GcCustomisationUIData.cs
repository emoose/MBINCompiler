using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3E20, GUID = 0x90C112BFF5940D96)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0xE)]
        public GcCustomisationUI[] CustomisationUIData;
    }
}
