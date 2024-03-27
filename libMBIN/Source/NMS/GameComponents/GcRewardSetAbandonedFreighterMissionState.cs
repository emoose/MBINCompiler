namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C56AC8AB40CE6A7, NameHash = 0xDEABEB9DAFEFB3D9)]
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
        /* 0x0 */ public AbandonedFreighterMissionStateEnum AbandonedFreighterMissionState;
        /* 0x4 */ public bool Silent;
    }
}
