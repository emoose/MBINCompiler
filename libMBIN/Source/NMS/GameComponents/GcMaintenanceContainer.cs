using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x29EC8F0047EB7B10)]
    public class GcMaintenanceContainer : NMSTemplate       // size: 0x80
    {
        /* 0x00 */ public GcInventoryContainer InventoryContainer;
        /* 0x60 */ public ulong LastUpdateTimestamp;
        /* 0x68 */ public List<float> DamageTimers;
        /* 0x78 */ public uint Flags;
    }
}
