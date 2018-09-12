using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x770A0, GUID = 0x0EB88B31198BC5E82)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0x9)]
        public GcCustomisationUI[] CustomisationUIData;
    }
}
