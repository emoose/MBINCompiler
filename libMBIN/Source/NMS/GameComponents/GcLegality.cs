namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5298DB0CDEA42330, NameHash = 0x769CBCB21A7D4913)]
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
