namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x853259960926BF67, NameHash = 0x9EB26F87ECDE68DC)]
    public class GcPlanetClass : NMSTemplate
    {
        // size: 0x3
        public enum PlanetClassEnum {
            Default,
            Initial,
            InInitialSystem
        }
        /* 0x0 */ public PlanetClassEnum PlanetClass;
    }
}
