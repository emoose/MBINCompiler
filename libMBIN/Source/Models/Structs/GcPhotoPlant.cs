namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x88D5BE0AA7AE6B79)]
    public class GcPhotoPlant : NMSTemplate
    {
		public enum PhotoPlantTypeEnum { Zinc, Thamium, Platinum }
		public PhotoPlantTypeEnum PhotoPlantType;
    }
}
