namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF9D37D80C52CAFEF, NameHash = 0x72439AF10F4C849F)]
    public class GcWikiTopicType : NMSTemplate
    {
        // size: 0x17
        public enum WikiTopicTypeEnum {
            Substances,
            CustomSubstanceList,
            Products,
            CustomProductList,
            CustomItemList,
            Technologies,
            CustomTechnologyList,
            BuildableTech,
            Construction,
            TradeCommodities,
            Curiosities,
            Cooking,
            StoneRunes,
            Words,
            RecipesAll,
            RecipesCooker,
            RecipesRefiner1,
            RecipesRefiner2,
            RecipesRefiner3,
            Guide,
            Stories,
            ProcTreasures,
            DebugSweep
        }
        /* 0x0 */ public WikiTopicTypeEnum WikiTopicType;
    }
}
