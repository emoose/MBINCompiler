namespace MBINCompiler.Models.Structs
{
    public class GcInteractionBuffer : NMSTemplate // 0x7D10 bytes
    {
        [NMS(Size = 0x3E8)]
        public GcInteractionData[] Interactions;

        public float CurrentPos;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding7D04;
    }
}
