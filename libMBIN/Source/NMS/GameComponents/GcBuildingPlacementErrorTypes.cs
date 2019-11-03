using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE7A224F2DA386498, NameHash = 0xC2EE53901B0156DE)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // 0x13 entries
        public enum InvalidPlacementReasonEnum {
            Offline, InvalidBiome, InvalidAboveWater, InvalidUnderwater, InvalidOverlappingBase, OutOfBaseRange, LimitReached, OutOfConnectionRange,
            LinkGridMismatch, InsufficientResources, ComplexityLimitReached, SubstanceOnly, RoomLimitReached, InvalidPosition, InvalidSnap, MustPlaceOnTerrain, Collision,
            ShipInside, PlayerInside
        }
        public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
