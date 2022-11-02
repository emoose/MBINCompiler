using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD91B6A560D9E576C, NameHash = 0x5B935AA89717BCC4)]
    public class GcCreatureHarvesterComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x2D0 */ public int NumSlots;
    }
}
