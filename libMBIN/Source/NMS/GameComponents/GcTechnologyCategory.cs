namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x3797D16E9397A243)]
    public class GcTechnologyCategory : NMSTemplate
    {
		public enum TechnologyCategoryEnum { Ship, Weapon, Suit, Personal, All, None, Freighter, Vehicle, Maintenance }
		public TechnologyCategoryEnum TechnologyCategory;
    }
}
