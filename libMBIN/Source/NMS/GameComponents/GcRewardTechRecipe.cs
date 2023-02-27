using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40BF19624B3A505A, NameHash = 0xAD73013CE22251D2)]
    public class GcRewardTechRecipe : NMSTemplate
    {
        /* 0x0 */ public GcTechnologyCategory Category;
        /* 0x8 */ public NMSString0x10 RewardGroup;
    }
}
