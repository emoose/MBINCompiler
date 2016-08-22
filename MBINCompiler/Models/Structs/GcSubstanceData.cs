using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSubstanceData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string NameLower;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Symbol;
        public TkTextureResource Icon;
        public TkModelResource Debris;
        public VariableSizeString Subtitle;
        public VariableSizeString Description;
        public Colour Colour;
        public Colour WorldColour;
        public int BaseValue;
        public GcRealitySubstanceCategory SubstanceCategory;
        public GcRarity Rarity;
        public GcLegality Legality;
        public int ChargeValue;
        public GcItemPriceModifiers Cost;
        public float NormalisedValueOnWorld;
        public float NormalisedValueOffWorld;
    }
}
