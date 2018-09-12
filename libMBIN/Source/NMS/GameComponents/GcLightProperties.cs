using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x166006DB2573EE25)]
    public class GcLightProperties : NMSTemplate
    {
        public Colour SunColour;
        public Colour LightColour;
        public Colour BounceColour;
    }
}
