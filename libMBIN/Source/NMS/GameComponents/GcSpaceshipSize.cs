namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CE65F04D0E94619, NameHash = 0xCA7F5D59)]
    public class GcSpaceshipSize : NMSTemplate
    {
        // size: 0x3
        public enum ShipSizeEnum : uint {
            None,
            Small,
            Large,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipSizeEnum ShipSize;
    }
}
