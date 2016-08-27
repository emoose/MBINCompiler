namespace MBINCompiler.Models.Structs
{
    public class GcDisplayText : NMSTemplate
    {
        public int HUDTextDisplayType;
        public string[] HUDTextDisplayTypeValues()
        {
            return new[] { "Full", "Compact", "EyeLevel", "Prompt", "Tooltip" };
        }

        [NMS(Size = 0x100)]
        public string Title;
        [NMS(Size = 0x100)]
        public string Subtitle1;
        [NMS(Size = 0x100)]
        public string Subtitle2;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding304;
    }
}
