namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B36892C3FD506C8, NameHash = 0x3D8CDA50E9CD9F10)]
    public class GcByteBeatEnvelope : NMSTemplate
    {
        // size: 0x3
        public enum ByteBeatEnvelopeEnum {
            Short,
            Med,
            Long
        }
        /* 0x0 */ public ByteBeatEnvelopeEnum ByteBeatEnvelope;
    }
}
