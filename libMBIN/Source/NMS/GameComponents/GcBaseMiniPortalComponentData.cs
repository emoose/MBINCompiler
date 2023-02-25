namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B51F3B80FECAB80, NameHash = 0xBBBD45634207B79F)]
    public class GcBaseMiniPortalComponentData : NMSTemplate
    {
        /* 0x00 */ public bool AllowVehicles;
        /* 0x01 */ public bool AllowSpawnedObjects;
        /* 0x02 */ public bool FlipFacingDirection;
        /* 0x03 */ public bool SnapFacingDirection;
        /* 0x04 */ public float SnapFacingAngle;
        /* 0x08 */ public bool DoPlayerEffects;
        /* 0x09 */ public bool TeleportCamera;
        /* 0x0C */ public int PowerCost;
        /* 0x10 */ public NMSString0x10 GroupID;
        /* 0x20 */ public NMSString0x10 DestinationGroupID;
        // size: 0x4
        public enum DestinationSortTypeEnum : uint {
            NearestPotal,
            BaseBuildingConnection,
            AbandonedFreighter,
            PortalNearestPlayerShip,
        }
        /* 0x30 */ public DestinationSortTypeEnum DestinationSortType;
    }
}
