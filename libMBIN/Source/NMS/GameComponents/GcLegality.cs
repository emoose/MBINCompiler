namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6864B5A32DD0871, NameHash = 0x769CBCB21A7D4913)]
    public class GcLegality : NMSTemplate
    {
        // size: 0x2
        public enum LegalityEnum {
            Legal,
            Illegal
        }
        /* 0x0 */ public LegalityEnum Legality;
    }
}
