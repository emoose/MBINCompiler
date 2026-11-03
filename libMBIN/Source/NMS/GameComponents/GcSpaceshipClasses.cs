namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEBC74D5EC70CAF, NameHash = 0x5179E0DF)]
    public class GcSpaceshipClasses : NMSTemplate
    {
        // size: 0xC
        public enum ShipClassEnum : uint {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail,
            Robot,
            Corvette,
            SwarmDrone,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipClassEnum ShipClass;
    }
}
