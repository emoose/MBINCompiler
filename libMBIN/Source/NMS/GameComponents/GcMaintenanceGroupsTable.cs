using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x97896CCD6D37AF95)]
    public class GcMaintenanceGroupsTable : NMSTemplate
    {
        [NMS(Size = 0x7, EnumValue = new string[7] { "Custom", "Farming", "Fuelling", "Repairing", "EasyRepairing", "Cleaning", "Frigate" })]
        public GcMaintenanceGroup[] Groups;
    }
}
