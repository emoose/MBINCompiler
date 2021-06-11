using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0xE83DEB8D25E796F3, NameHash = 0x4AF1E9D7AD4CC1C7)]
    public class GcMaintenanceContainer : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer InventoryContainer;
        /* 0x160 */ public ulong LastUpdateTimestamp;
        /* 0x168 */ public ulong LastCompletedTimestamp;
        /* 0x170 */ public ulong LastBrokenTimestamp;
        /* 0x178 */ public List<float> DamageTimers;
        /* 0x188 */ public ushort Flags;
    }
}
