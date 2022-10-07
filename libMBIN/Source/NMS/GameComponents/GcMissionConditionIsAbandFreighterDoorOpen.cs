namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6B95CB679B68391, NameHash = 0x337390D414A23798)]
    public class GcMissionConditionIsAbandFreighterDoorOpen : NMSTemplate
    {
        // size: 0x4
        public enum AbandonedFreighterDoorStatusEnum {
            DungeonNotReady,
            Locked,
            Opening,
            Open
        }
        /* 0x0 */ public AbandonedFreighterDoorStatusEnum AbandonedFreighterDoorStatus;
    }
}
