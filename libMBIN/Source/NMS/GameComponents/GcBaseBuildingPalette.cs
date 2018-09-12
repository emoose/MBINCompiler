using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x9BC6A89E878C831D)]
    public class GcBaseBuildingPalette : NMSTemplate
    {
        public Colour PrimaryColour;
        public Colour SecondaryColour;
        [NMS(Size = 0x20)]
        public string Name;
    }
}
