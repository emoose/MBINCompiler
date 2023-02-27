using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99DAFB16E0E4E2B1, NameHash = 0x5B935AA89717BCC4)]
    public class GcCreatureHarvesterComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x2E0 */ public int NumSlots;
    }
}
