using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0xCE1A64B4EE12B085)]
    public class GcPhotoFlora : NMSTemplate
    {
        public short AmountMin;
        public short AmountMax;
        public GcPhotoPlant PlanetType;
    }
}
