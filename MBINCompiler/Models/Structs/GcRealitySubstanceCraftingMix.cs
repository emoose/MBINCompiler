namespace MBINCompiler.Models.Structs
{
    public class GcRealitySubstanceCraftingMix : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string ID;

        public int Ratio;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
