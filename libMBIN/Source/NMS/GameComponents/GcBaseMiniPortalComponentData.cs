namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E9B14B8633CB4F5, NameHash = 0x16C75ED9)]
    public class GcBaseMiniPortalComponentData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x20A CorvetteTeleportInteractionName;
        [NMS(Index = 9)]
        /* 0x20 */ public NMSString0x10 DestinationGroupID;
        [NMS(Index = 8)]
        /* 0x30 */ public NMSString0x10 GroupID;
        [NMS(Index = 10)]
        /* 0x40 */ public int AssociatedCorvetteDockIndex;
        // size: 0x7
        public enum DestinationSortTypeEnum : uint {
            NearestPotal,
            BaseBuildingConnection,
            AbandonedFreighter,
            PortalNearestPlayerShip,
            ExitCorvette,
            ReturnToCorvette,
            ReturnToCorvetteOutpost,
        }
        [NMS(Index = 11)]
        /* 0x44 */ public DestinationSortTypeEnum DestinationSortType;
        [NMS(Index = 7)]
        /* 0x48 */ public int PowerCost;
        [NMS(Index = 4)]
        /* 0x4C */ public float SnapFacingAngle;
        [NMS(Index = 1)]
        /* 0x50 */ public bool AllowSpawnedObjects;
        [NMS(Index = 0)]
        /* 0x51 */ public bool AllowVehicles;
        [NMS(Index = 5)]
        /* 0x52 */ public bool DoPlayerEffects;
        [NMS(Index = 2)]
        /* 0x53 */ public bool FlipFacingDirection;
        [NMS(Index = 3)]
        /* 0x54 */ public bool SnapFacingDirection;
        [NMS(Index = 6)]
        /* 0x55 */ public bool TeleportCamera;
    }
}
