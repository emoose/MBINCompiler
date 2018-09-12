namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x85A1EEB4E962980B)]
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
