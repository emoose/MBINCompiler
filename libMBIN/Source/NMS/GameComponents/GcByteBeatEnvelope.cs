namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2105B955658DFDC2, NameHash = 0x3D8CDA50E9CD9F10)]
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
