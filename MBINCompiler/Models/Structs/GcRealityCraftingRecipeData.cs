namespace MBINCompiler.Models.Structs
{
    public class GcRealityCraftingRecipeData : NMSTemplate // 0x58 bytes
    {
        [NMS(Size = 3)]
        public GcRealitySubstanceCraftingMix[] Inputs;

        [NMS(Size = 0x10)]
        public string OutputID;
    }
}
