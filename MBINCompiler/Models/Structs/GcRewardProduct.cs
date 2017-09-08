namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x1C)]
    public class GcRewardProduct : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory Category;
        /* 0x04 */ public GcRarity Rarity;
        /* 0x08 */ public int ItemLevel;
        [NMS(Size = 5, EnumValue = new[] { "Component", "Device", "Consumable", "Curiosity", "BuildingPart" })]
        /* 0x0C */ public bool[] AllowedProductTypes;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x11 */ public byte[] Padding11;
        /* 0x14 */ public int AmountMin;
        /* 0x18 */ public int AmountMax;
    }
}
