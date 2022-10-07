namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x73A9CDAF4AF83232, NameHash = 0x2CE937F1C349DD12)]
    public class TkLSystemRestrictionData : NMSTemplate
    {
        /* 0x0 */ public int Amount;
        // size: 0x3
        public enum RestrictionEnum {
            NoMoreThan,
            AtLeast,
            AtLeastIfICan
        }
        /* 0x4 */ public RestrictionEnum Restriction;
    }
}
