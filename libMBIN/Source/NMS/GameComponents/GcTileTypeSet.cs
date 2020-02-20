using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x64, GUID = 0xD2A302F10249BA29, NameHash = 0x30CD85DD787F512A)]
    public class GcTileTypeSet : NMSTemplate
    {
        public float Probability;

        [NMS(Size = 0xC)]
        public TkPaletteTexture[] Colours;
    }
}
