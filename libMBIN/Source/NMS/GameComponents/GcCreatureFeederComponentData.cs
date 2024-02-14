using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E3D2BDB6A7FD3FB, NameHash = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x420 */ public int NumInputs;
        /* 0x424 */ public int NumMealsPerBait;
        /* 0x428 */ public List<NMSString0x100> DispenseNodes;
        /* 0x438 */ public float DispenseVelocity;
        /* 0x43C */ public float DispensePeriod;
    }
}
