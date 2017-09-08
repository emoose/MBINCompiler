using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcPersistentBase : NMSTemplate // size = 0x190
    {
        /* 0x000 */ public int BaseVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;

        /* 0x008 */ public ulong GalacticAddress;
        /* 0x010 */ public Vector4f Position;
        /* 0x020 */ public Vector4f Forward;
        /* 0x030 */ public ulong UserData;
        /* 0x038 */ public List<GcPersistentBaseEntry> Objects;

        [NMS(Size = 0x40)]
        /* 0x048 */ public string RID;
        /* 0x088 */ public GcDiscoveryOwner Owner;
        [NMS(Size = 0x40)]
        /* 0x14C */ public string Name;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
