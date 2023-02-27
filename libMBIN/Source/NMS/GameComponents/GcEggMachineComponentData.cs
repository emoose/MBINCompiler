using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12EE40712A7D1A7D, NameHash = 0x54575BF82BE5C4BA)]
    public class GcEggMachineComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x2E0 */ public int NumInputs;
    }
}
