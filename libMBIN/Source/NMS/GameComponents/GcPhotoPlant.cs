namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8B17E2691A6D0B, NameHash = 0xC1358572)]
    public class GcPhotoPlant : NMSTemplate
    {
        // size: 0x3
        public enum PhotoPlantTypeEnum : uint {
            Sodium,
            Oxygen,
            BluePlant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PhotoPlantTypeEnum PhotoPlantType;
    }
}
