namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CC5E340946F13ED, NameHash = 0xE1F664A6)]
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public Vector4f AbandonedFreighterPositionInSystem;
        [NMS(Index = 13)]
        /* 0x10 */ public Vector4f AbandonedFreighterTransformAt;
        [NMS(Index = 14)]
        /* 0x20 */ public Vector4f AbandonedFreighterTransformUp;
        [NMS(Index = 9)]
        /* 0x30 */ public Vector4f FreighterPositionInSystem;
        [NMS(Index = 10)]
        /* 0x40 */ public Vector4f FreighterTransformAt;
        [NMS(Index = 11)]
        /* 0x50 */ public Vector4f FreighterTransformUp;
        [NMS(Index = 2)]
        /* 0x60 */ public Vector4f PlayerDeathRespawnPositionInSystem;
        [NMS(Index = 3)]
        /* 0x70 */ public Vector4f PlayerDeathRespawnTransformAt;
        [NMS(Index = 0)]
        /* 0x80 */ public Vector4f PlayerPositionInSystem;
        [NMS(Index = 1)]
        /* 0x90 */ public Vector4f PlayerTransformAt;
        [NMS(Index = 4)]
        /* 0xA0 */ public Vector4f ShipPositionInSystem;
        [NMS(Index = 5)]
        /* 0xB0 */ public Vector4f ShipTransformAt;
        [NMS(Index = 6)]
        /* 0xC0 */ public Vector4f ShipTransformUp;
        // size: 0xA
        public enum LastKnownPlayerStateEnum : uint {
            OnFoot,
            InShip,
            InStation,
            AboardFleet,
            InNexus,
            AbandonedFreighter,
            InShipLanded,
            InVehicle,
            OnFootInCorvette,
            OnFootInCorvetteLanded,
        }
        [NMS(Index = 8)]
        /* 0xD0 */ public LastKnownPlayerStateEnum LastKnownPlayerState;
        [NMS(Index = 7)]
        /* 0xD4 */ public bool ShipHovering;
    }
}
