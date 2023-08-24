using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x512E13A0321C499E, NameHash = 0x30CD85DD787F512A)]
    public class GcTileTypeSet : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        [NMS(Size = 0xC)]
        /* 0x4 */ public TkPaletteTexture[] Colours;
    }
}
