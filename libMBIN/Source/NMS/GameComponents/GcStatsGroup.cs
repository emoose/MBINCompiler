using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEA3BCF2E77894A81)]
    public class GcStatsGroup : NMSTemplate     // size: 0xA8
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;

        /* 0x10 */ public TkTextureResource Icon;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding94;

        /* 0x98 */ public List<GcStatsEntry> StatIds;
    }
}
