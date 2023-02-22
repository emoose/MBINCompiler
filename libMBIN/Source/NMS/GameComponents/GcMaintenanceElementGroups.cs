namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4BFB23EFAF7D5A5, NameHash = 0x38F9072E9DC5078A)]
    public class GcMaintenanceElementGroups : NMSTemplate
    {
        // size: 0x7
        public enum MaintenanceGroupEnum {
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
