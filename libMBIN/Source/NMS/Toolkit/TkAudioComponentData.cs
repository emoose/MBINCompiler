using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x128, Alignment = 0x8, GUID = 0x52F00107D89FE21C, NameHash = 0x43843485E8F56932)]
    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Ambient;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string AmbientState;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string Shutdown;
        /* 0x110 */ public int MaxDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x114 */ public byte[] Padding114;
        /* 0x118 */ public List<TkAudioAnimTrigger> AnimTriggers;
    }
}
