using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA320FEFC871A5DDA, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x3E0 */ public int NumInputs;
        /* 0x3E4 */ public int NumMealsPerBait;
        /* 0x3E8 */ public List<NMSString0x100> DispenseNodes;
        /* 0x3F8 */ public float DispenseVelocity;
        /* 0x3FC */ public float DispensePeriod;
    }
}
