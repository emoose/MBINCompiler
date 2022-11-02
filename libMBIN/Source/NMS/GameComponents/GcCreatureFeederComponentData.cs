using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83434224AAC4DF2E, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x2D0 */ public int NumInputs;
        /* 0x2D4 */ public int NumMealsPerBait;
        /* 0x2D8 */ public List<NMSString0x100> DispenseNodes;
        /* 0x2E8 */ public float DispenseVelocity;
        /* 0x2EC */ public float DispensePeriod;
    }
}
