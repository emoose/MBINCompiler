using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B531C86B846FBEE, NameHash = 0x660230CBC714CB2C)]
    public class GcModularCustomisationSlotItemData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ItemID;
        /* 0x10 */ public List<NMSString0x10> ActivatedDescriptorGroupIDs;
    }
}
