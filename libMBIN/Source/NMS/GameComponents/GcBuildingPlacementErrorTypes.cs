namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83A6CB24B46258A, NameHash = 0x8CD019E0)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // size: 0x1A
        public enum InvalidPlacementReasonEnum : uint {
            Offline,
            InvalidBiome,
            InvalidAboveWater,
            InvalidUnderwater,
            PlanetLimitReached,
            BaseLimitReached,
            RegionLimitReached,
            InvalidMaxBasesReached,
            InvalidOverlappingAnyBase,
            InvalidOverlappingSettlement,
            InvalidOverlappingBase,
            OutOfBaseRange,
            OutOfConnectionRange,
            LinkGridMismatch,
            InsufficientResources,
            ComplexityLimitReached,
            SubstanceOnly,
            InvalidPosition,
            InvalidSnap,
            MustPlaceOnTerrain,
            MustPlaceWithSnap,
            Collision,
            ShipInside,
            PlayerInside,
            InvalidCorvettePosition,
            DisallowedByProtectedArea,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
