namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x384BDACEDB42E739, NameHash = 0xD4CCEA7B)]
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
        [NMS(Index = 0)]
        /* 0x0 */ public MaintenanceGroupEnum MaintenanceGroup;
    }
}
