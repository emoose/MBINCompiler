namespace libMBIN.Models.Structs
{
    public class GcInteractionBuffer : NMSTemplate // 0x7D00 bytes
    {
        [NMS(Size = 0x3E8)]
        public GcInteractionData[] Interactions;
    }
}
