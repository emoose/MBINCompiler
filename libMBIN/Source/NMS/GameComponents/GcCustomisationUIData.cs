using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4D0, GUID = 0x32350B4828942FA7)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0xE)]
        public GcCustomisationUI[] CustomisationUIData;
    }
}
