using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3861907A552DE380, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x2E0 */ public int NumInputs;
        /* 0x2E4 */ public int NumMealsPerBait;
        /* 0x2E8 */ public List<NMSString0x100> DispenseNodes;
        /* 0x2F8 */ public float DispenseVelocity;
        /* 0x2FC */ public float DispensePeriod;
    }
}
