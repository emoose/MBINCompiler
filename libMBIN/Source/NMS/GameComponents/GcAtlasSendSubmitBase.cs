using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x310, GUID = 0xAB84214205BC3F36, NameHash = 0xF6415333939D5563)]
    public class GcAtlasSendSubmitBase : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x000 */ public byte[] Padding0;
        /* 0x008 */ public ulong ClientUserdata;
        /* 0x010 */ public GcGameMode GameMode;
        /* 0x020 */ public GcPersistentBase BaseData;
        /* 0x2D0 */ public GcPersistentTerrainEdits TerrainData;
    }
}
