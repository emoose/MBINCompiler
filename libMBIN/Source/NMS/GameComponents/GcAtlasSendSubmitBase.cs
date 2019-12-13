using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x300, GUID = 0x1E3A3511CBD73A40, NameHash = 0xF6415333939D5563)]
    public class GcAtlasSendSubmitBase : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserdata;
        /* 0x008 */ public GcGameMode GameMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C */ public byte[] PaddingC;
        /* 0x010 */ public GcPersistentBase BaseData;
        /* 0x2C0 */ public GcAtlasRecvBlob TerrainData;
    }
}
