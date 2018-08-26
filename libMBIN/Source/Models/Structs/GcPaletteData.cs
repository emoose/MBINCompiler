namespace libMBIN.Models.Structs
{
    public class GcPaletteData : NMSTemplate        // size: 0x410
    {
        public int NumColours;      // to change this to an enum, the numbers will need to be written out (ie. 1 = One). This will break stuff for many current users I think...
        public string[] NumColoursValues()
        {
            return new[] { "Inactive", "1", "4", "8", "16", "All" };
        }

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        [NMS(Size = 0x40)]
        public Colour[] Colours;
    }
}
