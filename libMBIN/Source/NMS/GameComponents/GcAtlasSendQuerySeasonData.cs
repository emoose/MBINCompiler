using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x0CB7280358D558FF, NameHash = 0xB3FF565AF020F672)]
    public class GcAtlasSendQuerySeasonData : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
    }
}
