namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA225190DB7F444D, NameHash = 0xB1D42EFA923F8574)]
    public class GcSolarSystemLocatorTypes : NMSTemplate
    {
        // size: 0x4
        public enum LocatorTypeEnum {
            Generic1,
            Generic2,
            Generic3,
            Generic4
        }
        /* 0x0 */ public LocatorTypeEnum LocatorType;
    }
}
