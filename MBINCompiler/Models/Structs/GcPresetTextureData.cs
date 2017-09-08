namespace MBINCompiler.Models.Structs
{
    public class GcPresetTextureData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x100)]
        public string Filename;
    }
}
