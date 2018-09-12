using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x2874DA66C2CF0DB7)]
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
