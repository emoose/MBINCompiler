namespace MBINCompiler.Models.Structs
{
    public class TkLSystemGlobalVariation : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public int Variations;
    }
}
