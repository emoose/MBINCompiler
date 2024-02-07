using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF40D102EB6530A6, NameHash = 0x54575BF82BE5C4BA)]
    public class GcEggMachineComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x420 */ public int NumInputs;
    }
}
