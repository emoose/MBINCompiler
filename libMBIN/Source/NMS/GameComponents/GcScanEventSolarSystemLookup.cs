using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xA9721E588E7A8FC2)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        public bool UseStarType;
        public bool UseWealth;
        public bool Usetrading;
        public GcAlienRace Userace;
        public GcGalaxyStarAnomaly UseAnomaly;
        public GcPlayerConflictData UseConflict;
        public GcGalaxyStarTypes StarType;
        public GcPlanetTradingData TradingData;
        public bool NeedsWaterPlanet;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1D;
        [NMS(Size = 0x10)]
        public string NeedsResourceHint;
    }
}
