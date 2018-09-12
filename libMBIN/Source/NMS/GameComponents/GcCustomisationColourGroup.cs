namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x38, GUID = 0x0AF69A920435DE7D)]
    public class GcCustomisationColourGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string GroupID;
        [NMS(Size = 0x20)]
        public string Title;
        public TkPaletteTexture Palette;
    }
}
