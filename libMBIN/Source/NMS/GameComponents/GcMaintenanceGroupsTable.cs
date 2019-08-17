using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x97896CCD6D37AF95, SubGUID = 0x4819F209285AD45B)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new[] { "Custom", "Farming", "Fuelling", "Repairing", "EasyRepairing", "Cleaning", "Frigate" })]
        public GcMaintenanceGroup[] Groups;
    }
}
