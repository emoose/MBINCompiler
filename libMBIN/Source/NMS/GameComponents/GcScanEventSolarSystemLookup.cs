using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xAFF60C2283B69ADA)]
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
        public byte[] EndPadding;
    }
}
