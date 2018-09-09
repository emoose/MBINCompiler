namespace libMBIN.Models.Structs
{
	[NMS(Size = 0xA0, GUID = 0x0CFE1C74A7BD0885A)]
    public class GcPassiveFrigateIncomeArray : NMSTemplate
    {
        [NMS(Size = 0x5, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]
        public GcPassiveFrigateIncome[] Array;
    }
}
