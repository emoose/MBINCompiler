namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x843A3DAF82E8DFDF)]
    public class GcTileTypeSet : NMSTemplate
    {
        public float Probability;

        [NMS(Size = 0xC)]
        public TkPaletteTexture[] Colours;
    }
}
