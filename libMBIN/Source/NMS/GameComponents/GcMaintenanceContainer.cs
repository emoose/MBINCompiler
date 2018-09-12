using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3FEB12DC7AB9E2EC, Broken = true)]
    public class GcMaintenanceContainer : NMSTemplate       // size: 0x80
    {
        /* 0x00 */ public GcInventoryContainer InventoryContainer;
        /* 0x60 */ public ulong LastUpdateTimestamp;
        /* 0x68 */ public List<float> DamageTimers;
        /* 0x78 */ public uint Flags;
    }
}
