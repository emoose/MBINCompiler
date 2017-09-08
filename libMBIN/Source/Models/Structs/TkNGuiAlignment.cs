namespace MBINCompiler.Models.Structs
{
    public class TkNGuiAlignment : NMSTemplate
    {
        public int Vertical;
        public int Horizontal;

        public string[] VerticalValues()
        {
            return new[] { "Top", "Middle", "Bottom" };
        }


        public string[] HorizontalValues()
        {
            return new[] { "Left", "Center", "Right" };
        }
    }
}
