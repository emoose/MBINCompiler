namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6BA910CA04E93E6, NameHash = 0xB9B04C0CA0357C57)]
    public class GcSpaceshipClasses : NMSTemplate
    {
        // size: 0x9
        public enum ShipClassEnum {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail
        }
        /* 0x0 */ public ShipClassEnum ShipClass;
    }
}
