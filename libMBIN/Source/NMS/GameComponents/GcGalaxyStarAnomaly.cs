namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA11B55305BB14B0C, NameHash = 0x1C2295C9)]
    public class GcGalaxyStarAnomaly : NMSTemplate
    {
        // size: 0x6
        public enum GalaxyStarAnomalyEnum : uint {
            None,
            AtlasStation,
            AtlasStationFinal,
            BlackHole,
            MiniStation,
            BackgroundSwarmHive,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyStarAnomalyEnum GalaxyStarAnomaly;
    }
}
