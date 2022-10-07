namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8828B0BD2D0CD65, NameHash = 0x9699B119759C861B)]
    public class GcPlayerHazardType : NMSTemplate
    {
        // size: 0x6
        public enum HazardEnum {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation
        }
        /* 0x0 */ public HazardEnum Hazard;
    }
}
