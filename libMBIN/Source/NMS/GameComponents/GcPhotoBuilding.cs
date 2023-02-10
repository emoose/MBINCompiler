namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C7D2578FE93157F, NameHash = 0x2535C1B3F76633D)]
    public class GcPhotoBuilding : NMSTemplate
    {
        // size: 0xD
        public enum PhotoBuildingTypeEnum {
            Shelter,
            Abandoned,
            Shop,
            Outpost,
            RadioTower,
            Observatory,
            Depot,
            Monolith,
            Factory,
            Portal,
            Ruin,
            MissionTower,
            LargeBuilding,
        }
        /* 0x0 */ public PhotoBuildingTypeEnum PhotoBuildingType;
    }
}
