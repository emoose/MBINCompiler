namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x665B510E9A6208F3)]
    public class GcFrigateStatType : NMSTemplate
    {
		public enum FrigateStatTypeEnum { Combat, Exploration, Mining, Diplomatic, FuelBurnRate, FuelCapacity, Speed, ExtraLoot, Repair, Invulnerable }
		public FrigateStatTypeEnum FrigateStatType;
    }
}
