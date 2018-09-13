using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F0, GUID = 0xFFAE980364845808)]
    public class GcAtlasSendSubmitBase : NMSTemplate
    {
        /* 0x000 */ public ulong ClientUserdata;
        /* 0x008 */ public GcGameMode GameMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C */ public byte[] PaddingC;
        /* 0x010 */ public GcPersistentBase Bases;
        /* 0x1B0 */ public List<GcTerrainEditsBuffer> BaseTerrainEdits;     // probably GcAtlasRecvBlob
    }
}
