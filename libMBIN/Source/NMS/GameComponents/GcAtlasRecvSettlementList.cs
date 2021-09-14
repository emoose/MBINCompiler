using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1EDE0, GUID = 0x6834FFF99F688B0A, NameHash = 0xCE8A17798827ECBE)]
    public class GcAtlasRecvSettlementList : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfSettlements;
        [NMS(Size = 0x64)]
        /* 0x20 */ public GcSettlementState[] Settlements;
    }
}
