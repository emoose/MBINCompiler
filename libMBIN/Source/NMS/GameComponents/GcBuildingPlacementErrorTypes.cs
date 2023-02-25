namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA85C40C7D96F32C, NameHash = 0xC2EE53901B0156DE)]
    public class GcBuildingPlacementErrorTypes : NMSTemplate
    {
        // size: 0x16
        public enum InvalidPlacementReasonEnum : uint {
            Offline,
            InvalidBiome,
            InvalidAboveWater,
            InvalidUnderwater,
            PlanetLimitReached,
            BaseLimitReached,
            RegionLimitReached,
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
