using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEA1F67D024C2D20C, NameHash = 0xA5FDDD239156B452)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0xD
		public enum TechnologyCategoryEnum { Ship, Weapon, Suit, Personal, All, None, Freighter, Maintenance, Exocraft, Submarine, AllVehicles, AlienShip, AllShips }
		public TechnologyCategoryEnum TechnologyCategory;
    }
}
