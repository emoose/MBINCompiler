namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD1F6B1FCAA20E51, NameHash = 0xF9DF8359)]
    public class GcRewardRequirementsForRecipe : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 RecipeID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool RewardInCreative;
    }
}
