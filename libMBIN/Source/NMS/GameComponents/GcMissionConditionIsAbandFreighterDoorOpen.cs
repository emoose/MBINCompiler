namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFD34699EA379432, NameHash = 0x455123FA)]
    public class GcMissionConditionIsAbandFreighterDoorOpen : NMSTemplate
    {
        // size: 0x4
        public enum AbandonedFreighterDoorStatusEnum : uint {
            DungeonNotReady,
            Locked,
            Opening,
            Open,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AbandonedFreighterDoorStatusEnum AbandonedFreighterDoorStatus;
    }
}
