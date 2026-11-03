namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x740E69371D6615DB, NameHash = 0x1ADEA025)]
    public class GcBuildingDensityLevels : NMSTemplate
    {
        // size: 0x8
        public enum BuildingDensityEnum : uint {
            Dead,
            Low,
            Mid,
            Full,
            Weird,
            HalfWeird,
            Waterworld,
            GasGiant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BuildingDensityEnum BuildingDensity;
    }
}
