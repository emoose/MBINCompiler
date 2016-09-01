using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcTradeData : NMSTemplate
    {
        public List<NMSString0x10> AlwaysPresentProducts;
        public List<NMSString0x10> AlwaysPresentSubstances;

        public int MinItemsForSale;
        public int MaxItemsForSale;
        public float PercentageOfItemsAreProducts;
        public int MinAmountOfProductAvailable;
        public int MaxAmountOfProductAvailable;
        public int MinAmountOfSubstanceAvailable;
        public int MaxAmountOfSubstanceAvailable;
        public bool HasStarItems;
        public int MinNumberOfStarItems;
        public int MaxNumberOfStarItems;
        public float StarItemMarkUp;
    }
}
