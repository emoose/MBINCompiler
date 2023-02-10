namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81CA6BB74FA453AC, NameHash = 0xC66C80C1B41A77FD)]
    public class GcSolarSystemClass : NMSTemplate
    {
        // size: 0x4
        public enum SolarSystemClassEnum {
            Default,
            Initial,
            Anomaly,
            GameStart,
        }
        /* 0x0 */ public SolarSystemClassEnum SolarSystemClass;
    }
}
