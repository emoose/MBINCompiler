using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x873BD47ED626D3F3, NameHash = 0x45DFFC6E8B36F6B7)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcPassiveFrigateIncome[] Array;
    }
}
