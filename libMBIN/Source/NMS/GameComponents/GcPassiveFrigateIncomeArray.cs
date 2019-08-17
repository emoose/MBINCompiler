using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xCFE1C74A7BD0885A, SubGUID = 0x45DFFC6E8B36F6B7)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]
        public GcPassiveFrigateIncome[] Array;
    }
}
