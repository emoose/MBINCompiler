using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF4B1C508C663D7, NameHash = 0x4AF1E9D7AD4CC1C7)]
    public class GcMaintenanceContainer : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer InventoryContainer;
        /* 0x158 */ public ulong LastUpdateTimestamp;
        /* 0x160 */ public ulong LastCompletedTimestamp;
        /* 0x168 */ public ulong LastBrokenTimestamp;
        /* 0x170 */ public List<float> DamageTimers;
        /* 0x180 */ public List<float> AmountAccumulators;
        /* 0x190 */ public ushort Flags;
    }
}
