namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDBE375351057547B, NameHash = 0x34F3A56DC1D3CE80)]
    public class GcHazardValueTypes : NMSTemplate
    {
        // size: 0x5
        public enum HazardValueEnum : uint {
            Ambient,
            Water,
            Cave,
            Storm,
            Night,
        }
        /* 0x0 */ public HazardValueEnum HazardValue;
    }
}
