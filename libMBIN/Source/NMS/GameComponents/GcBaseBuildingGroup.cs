using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, GUID = 0xE02205656427F42D)]
    public class GcBaseBuildingGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string ParentGroup;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string Name;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0x94 */ public int ColourIdx;
    }
}
