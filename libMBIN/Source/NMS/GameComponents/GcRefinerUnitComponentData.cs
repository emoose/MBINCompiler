using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21E38B61CDDC6F9, NameHash = 0xD2A73F296D17A20)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x3A0 */ public int NumInputs;
        /* 0x3A4 */ public bool IsCooker;
    }
}
