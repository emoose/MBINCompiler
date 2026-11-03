namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE51197160ACEF6C7, NameHash = 0xEAABC6B9)]
    public class GcLegality : NMSTemplate
    {
        // size: 0x2
        public enum LegalityEnum : uint {
            Legal,
            Illegal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LegalityEnum Legality;
    }
}
