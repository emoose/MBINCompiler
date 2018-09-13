using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x8C5ED23DB60A71EE, Broken = true)]
    public class GcAtlasRecvBaseList : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public int NumberOfbases;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        public List<GcPersistentBase> Bases;
        public List<GcTerrainEditsBuffer> BaseTerrainEdits;     // probably GcAtlasRecvBlob
    }
}
