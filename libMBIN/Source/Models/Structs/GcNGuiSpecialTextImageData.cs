namespace MBINCompiler.Models.Structs
{
    public class GcNGuiSpecialTextImageData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public bool ScaleToFitFont;
        public Vector2f Size;

        [NMS(Size = 0x80)]
        public string Path;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding9C;
    }
}
