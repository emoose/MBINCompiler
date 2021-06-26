using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x675486DA58825074, NameHash = 0xB457288101712FB5)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        public NMSString0x10 Id;
        public GcRewardTableItemList List;
    }
}