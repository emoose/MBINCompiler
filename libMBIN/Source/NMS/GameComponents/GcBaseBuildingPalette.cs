using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0xDB06717A3D9ED878, NameHash = 0xB499CC97C0515963)]
    public class GcBaseBuildingPalette : NMSTemplate
    {
        /* 0x00 */ public Colour PrimaryColour;
        /* 0x10 */ public Colour SecondaryColour;
        /* 0x20 */ public Colour TernaryColour;
        /* 0x30 */ public Colour QuaternaryColour;
        /* 0x40 */ public NMSString0x20A Name;
        /* 0x60 */ public NMSString0x20A Id;
    }
}
