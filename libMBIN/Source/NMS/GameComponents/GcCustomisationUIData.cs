using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5D8, GUID = 0x95E208F53B55E144, NameHash = 0xFA6C3AD3E80DE203)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        public GcCustomisationUI[] CustomisationUIData;
    }
}
