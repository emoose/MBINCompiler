namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8944A35F1313994, NameHash = 0xC2EE53901B0156DE)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // size: 0x17
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
            Collision,
            ShipInside,
            PlayerInside,
        }
        /* 0x0 */ public InvalidPlacementReasonEnum InvalidPlacementReason;
    }
}
