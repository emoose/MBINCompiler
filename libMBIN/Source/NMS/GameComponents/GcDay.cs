namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AF7F1C3674147C5, NameHash = 0xE8931C5D607657DE)]
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
