namespace MBINCompiler.Models.Structs
{
    public class GcDisplayText : NMSTemplate
    {
        public int HUDTextDisplayType;      // size: 0x304
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
    }
}
