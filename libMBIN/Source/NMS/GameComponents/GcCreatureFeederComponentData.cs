using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA71093EAF1228DC6, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x3A0 */ public int NumInputs;
        /* 0x3A4 */ public int NumMealsPerBait;
        /* 0x3A8 */ public List<NMSString0x100> DispenseNodes;
        /* 0x3B8 */ public float DispenseVelocity;
        /* 0x3BC */ public float DispensePeriod;
    }
}
