namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC73DD3B92E35C5CE, NameHash = 0x38F9072E9DC5078A)]
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
            Frigate
        }
        /* 0x0 */ public MaintenanceGroupEnum MaintenanceGroup;
    }
}
