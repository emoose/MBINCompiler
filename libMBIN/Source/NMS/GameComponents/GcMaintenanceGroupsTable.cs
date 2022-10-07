using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97896CCD6D37AF95, NameHash = 0x4819F209285AD45B)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        // size: 0x7
        public enum GroupsEnum {
            Custom,
            Farming,
            Fuelling,
            Repairing,
            EasyRepairing,
            Cleaning,
            Frigate
        }
        [NMS(Size = 0x7, EnumType = typeof(GroupsEnum))]
        /* 0x0 */ public GcMaintenanceGroup[] Groups;
    }
}
