using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43DC533FED87C720, NameHash = 0xA9467AFF)]
    public class GcSurvivalBarBoolArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcPlayerSurvivalBarType.SurvivalBarEnum))]
        /* 0x0 */ public bool[] Values;
    }
}
