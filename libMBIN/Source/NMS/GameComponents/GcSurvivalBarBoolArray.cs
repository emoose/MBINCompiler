using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D028937309C015C, NameHash = 0xF323538389A223A0)]
    public class GcSurvivalBarBoolArray : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcPlayerSurvivalBarType.SurvivalBarEnum))]
        /* 0x0 */ public bool[] Values;
    }
}
