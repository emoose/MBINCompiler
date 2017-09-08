namespace libMBIN.Models.Structs
{
    public class GcPaletteList : NMSTemplate        // size: 0xA690
    {
        [NMS(Size = 0x29)]
        public GcPaletteData[] Palettes;
    }
}
