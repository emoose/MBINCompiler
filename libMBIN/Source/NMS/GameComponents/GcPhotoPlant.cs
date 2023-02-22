namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEC58C1CD705E809, NameHash = 0xEFC8FCE1F6004590)]
    public class GcPhotoPlant : NMSTemplate
    {
        // size: 0x3
        public enum PhotoPlantTypeEnum {
            Sodium,
            Oxygen,
            BluePlant,
        }
        /* 0x0 */ public PhotoPlantTypeEnum PhotoPlantType;
    }
}
