namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8E46A0413013EDB, NameHash = 0xBAB78A04)]
    public class GcRewardSetAbandonedFreighterMissionState : NMSTemplate
    {
        // size: 0x6
        public enum AbandonedFreighterMissionStateEnum : uint {
            EndRoomComplete,
            CrewManifestRead,
            CaptainsLogRead,
            HazardOn,
            SlowWalkOn,
            OpenDoors,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AbandonedFreighterMissionStateEnum AbandonedFreighterMissionState;
        [NMS(Index = 1)]
        /* 0x4 */ public bool Silent;
    }
}
