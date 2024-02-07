using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x261C238F09EB1730, NameHash = 0xB457288101712FB5)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcRewardTableItemList List;
    }
}
