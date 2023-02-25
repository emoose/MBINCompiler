namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7799F4552A81DC2, NameHash = 0xA5FDDD239156B452)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0xE
        public enum TechnologyCategoryEnum : uint {
            Ship,
            Weapon,
            Suit,
            Personal,
            All,
            None,
            Freighter,
            Maintenance,
            Exocraft,
            Submarine,
            Mech,
            AllVehicles,
            AlienShip,
            AllShips,
        }
        /* 0x0 */ public TechnologyCategoryEnum TechnologyCategory;
    }
}
