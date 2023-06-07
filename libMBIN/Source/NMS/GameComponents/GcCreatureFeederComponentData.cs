using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC20AF5B1719F4168, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x3F0 */ public int NumInputs;
        /* 0x3F4 */ public int NumMealsPerBait;
        /* 0x3F8 */ public List<NMSString0x100> DispenseNodes;
        /* 0x408 */ public float DispenseVelocity;
        /* 0x40C */ public float DispensePeriod;
    }
}
