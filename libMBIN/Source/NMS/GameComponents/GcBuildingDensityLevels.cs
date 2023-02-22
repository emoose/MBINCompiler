namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFC51D0A61F9D3E, NameHash = 0x43EB5D40DE6AD28E)]
    public class GcBuildingDensityLevels : NMSTemplate
    {
        // size: 0x6
        public enum BuildingDensityEnum {
            Dead,
            Low,
            Mid,
            Full,
            Weird,
            HalfWeird,
        }
        /* 0x0 */ public BuildingDensityEnum BuildingDensity;
    }
}
