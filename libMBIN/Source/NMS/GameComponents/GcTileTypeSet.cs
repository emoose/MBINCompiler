using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA2AED35A90BBF6, NameHash = 0x30CD85DD787F512A)]
    public class GcTileTypeSet : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        [NMS(Size = 0xC)]
        /* 0x4 */ public TkPaletteTexture[] Colours;
    }
}
