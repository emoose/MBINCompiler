namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC126798830E34D7, NameHash = 0x606323F9)]
    public class GcPhotoBuilding : NMSTemplate
    {
        // size: 0xD
        public enum PhotoBuildingTypeEnum : uint {
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
        [NMS(Index = 0)]
        /* 0x0 */ public PhotoBuildingTypeEnum PhotoBuildingType;
    }
}
