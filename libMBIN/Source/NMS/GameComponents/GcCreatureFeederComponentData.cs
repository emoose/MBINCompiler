using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x260, GUID = 0xFB5163F6414302D2, SubGUID = 0x32441F8B4528DF91)]
    public class GcCreatureFeederComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        /* 0x240 */ public int NumInputs;
        /* 0x244 */ public int NumMealsPerBait;
        /* 0x248 */ public List<NMSString0x100> DispenseNodes;
        /* 0x258 */ public float DispenseVelocity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x25C */ public byte[] EndPadding;
    }
}
