namespace libMBIN.Models.Structs
{
    public class GcPaletteData : NMSTemplate        // size: 0x410
    {
        public int NumColours;
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
