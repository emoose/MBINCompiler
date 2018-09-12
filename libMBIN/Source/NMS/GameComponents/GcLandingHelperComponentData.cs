using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C9B4A9F531E84B81)]
    public class GcLandingHelperComponentData : NMSTemplate
    {
        public float ActiveDistanceMin;
        public float ActiveDistanceMax;
        public bool LandPoint;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding9;
    }
}
