namespace libMBIN.Models.Structs
{
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;

        public float PositionX;
        public float PositionY;
        public float SizeX;
        public float SizeY;
        public float Separator;
        public int WindowState;
        public string[] WindowStateValues()
        {
            return new[] { "Open", "Minimised", "Closed" };
        }

        [NMS(Size = 8)]
        public NMSString0x20[] Tabs;
    }
}
