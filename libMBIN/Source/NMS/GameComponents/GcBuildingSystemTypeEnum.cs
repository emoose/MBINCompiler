namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1DE140E8944E421, NameHash = 0xF7C03908)]
    public class GcBuildingSystemTypeEnum : NMSTemplate
    {
        // size: 0x2
        public enum BuildingSystemTypeEnum : uint {
            Normal,
            AbandonedSystem,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BuildingSystemTypeEnum BuildingSystemType;
    }
}
