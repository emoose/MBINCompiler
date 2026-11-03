using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36176272945E4234, NameHash = 0x8603D7E)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcPassiveFrigateIncome[] Array;
    }
}
