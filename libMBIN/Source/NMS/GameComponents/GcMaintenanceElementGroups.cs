namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1438CF5DEF8AB12B, NameHash = 0x38F9072E9DC5078A)]
    public class GcMaintenanceElementGroups : NMSTemplate
    {
        // size: 0x9
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
        }
        /* 0x0 */ public MaintenanceGroupEnum MaintenanceGroup;
    }
}
