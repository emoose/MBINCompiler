namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56884BB3E519A5CC, NameHash = 0x38F9072E9DC5078A)]
    public class GcMaintenanceElementGroups : NMSTemplate
    {
        // size: 0x7
        public enum MaintenanceGroupEnum : uint {
            Custom,
            Farming,
            Fuelling,
            Repairing,
            EasyRepairing,
            Cleaning,
            Frigate,
        }
        /* 0x0 */ public MaintenanceGroupEnum MaintenanceGroup;
    }
}
