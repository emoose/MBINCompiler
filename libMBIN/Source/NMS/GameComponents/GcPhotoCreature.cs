using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4B5EF55FB79A7A45)]
    public class GcPhotoCreature : NMSTemplate
    {
		public enum PhotoCreatureTypeEnum { Ground, Water, Air }
		public PhotoCreatureTypeEnum PhotoCreatureType;
    }
}
