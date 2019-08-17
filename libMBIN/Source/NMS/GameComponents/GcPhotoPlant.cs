using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x88D5BE0AA7AE6B79, SubGUID = 0xEFC8FCE1F6004590)]
    public class GcPhotoPlant : NMSTemplate
    {
		public enum PhotoPlantTypeEnum { Zinc, Thamium, Platinum }
		public PhotoPlantTypeEnum PhotoPlantType;
    }
}
