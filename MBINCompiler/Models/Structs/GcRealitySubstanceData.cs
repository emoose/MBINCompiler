namespace MBINCompiler.Models.Structs
{
    public class GcRealitySubstanceData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x20)]
        public string NameLower;
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x20)]
        public string Symbol;
        public TkTextureResource Icon;
        public TkModelResource DebrisFile;
        public VariableSizeString Subtitle;
        public VariableSizeString Description;
        public Colour Colour;
        public Colour WorldColour;
        public int BaseValue;
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public GcLegality Legality;
        public int ChargeValue;
        public GcItemPriceModifiers Cost;
        public float NormalisedValueOnWorld;
        public float NormalisedValueOffWorld;
    }
}
