using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x78, GUID = 0xA3DC5C9BE0167D37, NameHash = 0xA14126BE226C6660)]
    public class GcActionSet : NMSTemplate
    {
        /* 0x00 */ public GcActionSetType Type;
        /* 0x04 */ public GcActionUseType Status;
        /* 0x08 */ public NMSString0x20 ExternalId;
        /* 0x28 */ public NMSString0x20 ExternalLoc;
        /* 0x48 */ public NMSString0x20A LocTag;
        /* 0x68 */ public List<GcActionSetAction> Actions;
    }
}
