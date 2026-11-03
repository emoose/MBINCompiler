using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8521C674143D3E6E, NameHash = 0x14395E2)]
    public class GcRewardTechRecipe : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 RewardGroup;
        [NMS(Index = 0)]
        /* 0x10 */ public GcTechnologyCategory Category;
    }
}
