using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcProductData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x80)]
        public string NameLower;
        public VariableSizeString Subtitle;
        public VariableSizeString Description;
        [NMS(Size = 0x20)]
        public string Hint;
        public TkModelResource Debis;
        public int BaseValue;
        public int Level;
        public TkTextureResource Icon;
        public Colour Colour;
        public GcRealitySubstanceCategory SubstanceCategory;
        public GcProductCategory Category;
        public GcRarity Rarity;
        public GcLegality Legality;
        public bool Consumable;
        public int ChargeValue;
        public List<GcTechnologyRequirement> Requirements;
        public GcItemPriceModifiers Cost;
        public bool SpecificChargeOnly;
        public float NormalisedValueOnWorld;
        public float NormalisedValueOffWorld;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        [NMS(Ignore = true)]
        public int EmptyNode2;
    }
}
