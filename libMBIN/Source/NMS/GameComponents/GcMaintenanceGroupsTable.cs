using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4030413BD4279109, NameHash = 0x4819F209285AD45B)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcMaintenanceElementGroups.MaintenanceGroupEnum))]
        /* 0x0 */ public GcMaintenanceGroup[] Groups;
    }
}
