using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22B252B6D5AEE25B, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x400 */ public int NumInputs;
        /* 0x404 */ public int NumMealsPerBait;
        /* 0x408 */ public List<NMSString0x100> DispenseNodes;
        /* 0x418 */ public float DispenseVelocity;
        /* 0x41C */ public float DispensePeriod;
    }
}
