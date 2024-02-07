using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CF80D93F5E4CE97, NameHash = 0xD2A73F296D17A20)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x420 */ public int NumInputs;
        /* 0x424 */ public bool IsCooker;
    }
}
