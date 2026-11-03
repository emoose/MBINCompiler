using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1C73D0DFADEC7BB6, NameHash = 0xD1DB960B)]
    public class GcModularCustomisationSlotItemData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcModularCustomisationDescriptorGroupData> DescriptorGroupData;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ItemID;
        [NMS(Index = 5)]
        /* 0x20 */ public VariableSizeString SpecificLocID;
        [NMS(Index = 6)]
        /* 0x30 */ public GcCreatureDiet CreatureDiet;
        // size: 0x2
        public enum DescriptorGroupSalvageRuleEnum : uint {
            All,
            Any,
        }
        [NMS(Index = 1)]
        /* 0x34 */ public DescriptorGroupSalvageRuleEnum DescriptorGroupSalvageRule;
        [NMS(Index = 4)]
        /* 0x38 */ public GcInventoryClass InventoryClass;
        [NMS(Index = 3)]
        /* 0x3C */ public bool SetInventoryClass;
        [NMS(Index = 7)]
        /* 0x3D */ public bool UseAltCamera;
    }
}
