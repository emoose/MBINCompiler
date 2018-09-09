using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8246371C1D8ECBA2)]
    public class GcScanEventSolarSystemLookup : NMSTemplate      // size: 0x1C
    {
        public bool UseStarType;
        public bool UseWealth;
        public bool Usetrading;
        public GcAlienRace Userace;
        public GcGalaxyStarAnomaly UseAnomaly;
        public GcPlayerConflictData UseConflict;
        public GcGalaxyStarTypes StarType;
        public GcPlanetTradingData TradingData;
    }
}
