using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMaintenanceContainer : NMSTemplate       // size: 0x80
    {
        /* 0x00 */ public GcInventoryContainer InventoryContainer;
        /* 0x60 */ public ulong LastUpdateTimestamp;
        /* 0x68 */ public List<float> DamageTimers;
        /* 0x78 */ public uint Flags;
    }
}
