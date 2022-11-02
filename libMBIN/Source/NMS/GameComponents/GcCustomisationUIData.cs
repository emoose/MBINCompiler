using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DD9A30BE9EDE9B2, NameHash = 0xFA6C3AD3E80DE203)]
    public class GcCustomisationUIData : NMSTemplate
    {
        [NMS(Size = 0x14, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0 */ public GcCustomisationUI[] CustomisationUIData;
    }
}
