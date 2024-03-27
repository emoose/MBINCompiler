namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7C86F8E288C9667, NameHash = 0x38F9072E9DC5078A)]
    public class GcMaintenanceElementGroups : NMSTemplate
    {
        // size: 0xA
        public enum MaintenanceGroupEnum : uint {
            Custom,
            Farming,
            Fuelling,
            Repairing,
            EasyRepairing,
            Cleaning,
            Frigate,
            Sentinels,
            Runes,
            RobotHeads,
        }
        /* 0x0 */ public MaintenanceGroupEnum MaintenanceGroup;
    }
}
