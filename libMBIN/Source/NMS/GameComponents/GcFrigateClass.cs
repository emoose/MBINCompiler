namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0AB2EFFD5A99D806E)]
    public class GcFrigateClass : NMSTemplate
    {
		public enum FrigateClassEnum { Combat, Exploration, Mining, Diplomacy, Support }
		public FrigateClassEnum FrigateClass;
    }
}
