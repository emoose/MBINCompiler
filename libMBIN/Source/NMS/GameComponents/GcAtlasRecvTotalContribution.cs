using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x88D927C5D3ACE8D9, NameHash = 0x0BB8B54516B54A343)]
    public class GcAtlasRecvTotalContribution : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public bool Success;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] Padding11;
        /* 0x18 */ public ulong TotalContribution;
    }

}
