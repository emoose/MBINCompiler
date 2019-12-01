using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE558523281E02943, NameHash = 0xC2EE53901B0156DE)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // 0x14 entries
        public enum InvalidPlacementReasonEnum {
            Offline, InvalidBiome, InvalidAboveWater, InvalidUnderwater, PlanetLimitReached, BaseLimitReached, RegionLimitReached, InvalidOverlappingBase, OutOfBaseRange, OutOfConnectionRange,
            LinkGridMismatch, InsufficientResources, ComplexityLimitReached, SubstanceOnly, InvalidPosition, InvalidSnap, MustPlaceOnTerrain, Collision, ShipInside, PlayerInside
        }
        public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
