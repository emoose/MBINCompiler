namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7F08F599DEE041B, NameHash = 0xE8931C5D607657DE)]
    public class GcDay : NMSTemplate
    {
        // size: 0x7
        public enum DayEnum {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        /* 0x0 */ public DayEnum Day;
    }
}
