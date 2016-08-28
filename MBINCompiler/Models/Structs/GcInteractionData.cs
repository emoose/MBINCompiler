namespace MBINCompiler.Models.Structs
{
    public class GcInteractionData : NMSTemplate // 0x20 bytes
    {
        public ulong GalacticAddress;
        public float Value;
        public bool Flag;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] PaddingD;

        public Vector4f Position;
    }
}
