namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA27B4D68D05DF7F, NameHash = 0xA5FDDD239156B452)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0xE
        public enum TechnologyCategoryEnum {
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
