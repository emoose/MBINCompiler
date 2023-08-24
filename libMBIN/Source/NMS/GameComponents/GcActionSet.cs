using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C0872F794AFE229, NameHash = 0xA14126BE226C6660)]
    public class GcActionSet : NMSTemplate
    {
        /* 0x00 */ public GcActionSetType Type;
        /* 0x04 */ public GcActionUseType Status;
        /* 0x08 */ public NMSString0x20 ExternalId;
        /* 0x28 */ public NMSString0x20 ExternalLoc;
        /* 0x48 */ public NMSString0x20A LocTag;
        /* 0x68 */ public NMSString0x20 ParentExternalId;
        /* 0x88 */ public List<GcActionSetAction> Actions;
        /* 0x98 */ public List<GcInputActions> BlockedActions;
    }
}
