namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3BEF01141F3B96, NameHash = 0x7202A230)]
    public class GcPlanetClass : NMSTemplate
    {
        // size: 0x3
        public enum PlanetClassEnum : uint {
            Default,
            Initial,
            InInitialSystem,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PlanetClassEnum PlanetClass;
    }
}
