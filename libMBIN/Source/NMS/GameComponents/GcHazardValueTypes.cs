namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2802C85DF23FF533, NameHash = 0x34F3A56DC1D3CE80)]
    public class GcHazardValueTypes : NMSTemplate
    {
        // size: 0x5
        public enum HazardValueEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        /* 0x0 */ public HazardValueEnum HazardValue;
    }
}
