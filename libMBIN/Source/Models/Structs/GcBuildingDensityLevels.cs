namespace libMBIN.Models.Structs
{
    public class GcBuildingDensityLevels : NMSTemplate
    {
		public enum BuildingDensityEnum { Dead, Low, Mid, Full, RelicOnly, IndustrialOnly }
		public BuildingDensityEnum BuildingDensity;
    }
}
