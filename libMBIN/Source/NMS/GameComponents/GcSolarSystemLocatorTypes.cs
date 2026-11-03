namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4CEB1983B3F6618, NameHash = 0xB5ACCECE)]
    public class GcSolarSystemLocatorTypes : NMSTemplate
    {
        // size: 0x4
        public enum LocatorTypeEnum : uint {
            Generic1,
            Generic2,
            Generic3,
            Generic4,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LocatorTypeEnum LocatorType;
    }
}
