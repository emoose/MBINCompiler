namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1EB7B78C7FCE79F, NameHash = 0xE74EFBD5)]
    public class GcPlanetSize : NMSTemplate
    {
        // size: 0x5
        public enum PlanetSizeEnum : uint {
            Large,
            Medium,
            Small,
            Moon,
            Giant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PlanetSizeEnum PlanetSize;
    }
}
