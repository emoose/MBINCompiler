namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB644CB5C70DF0CE3, NameHash = 0x570640A8)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0x12
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
            Colossus,
            Submarine,
            Mech,
            AllVehicles,
            AlienShip,
            AllShips,
            RobotShip,
            AllShipsExceptAlien,
            Corvette,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TechnologyCategoryEnum TechnologyCategory;
    }
}
