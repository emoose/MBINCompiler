namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D930090CE3C00E66)]
    public class GcGalaxyStarAnomaly : NMSTemplate
    {
		public enum GalaxyStarAnomalyEnum { None, AtlasStation, AtlasStationFinal, BlackHole, MiniStation }
		public GalaxyStarAnomalyEnum GalaxyStarAnomaly;
    }
}
