using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89E9F3DF05E7563B, NameHash = 0xD2A73F296D17A20)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x420 */ public int NumInputs;
        /* 0x424 */ public bool IsCooker;
    }
}
