namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54988B2AD57EB6ED, NameHash = 0x94E48FB7)]
    public class GcPhotoShip : NMSTemplate
    {
        // size: 0xC
        public enum PhotoShipTypeEnum : uint {
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
        /* 0x0 */ public PhotoShipTypeEnum PhotoShipType;
    }
}
