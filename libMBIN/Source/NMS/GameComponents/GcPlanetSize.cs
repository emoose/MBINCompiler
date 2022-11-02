namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10AC94DE1B08C30D, NameHash = 0xE198F55796BC6E2F)]
    public class GcPlanetSize : NMSTemplate
    {
        // size: 0x4
        public enum PlanetSizeEnum {
            Large,
            Medium,
            Small,
            Moon
        }
        /* 0x0 */ public PlanetSizeEnum PlanetSize;
    }
}
