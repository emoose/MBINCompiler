namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x11F0)]
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x29, EnumValue = new[]
            {
                "Grass", "Plant", "Leaf", "Wood", "Rock", "Stone", "Crystal", "Sand",
                "Dirt", "Metal", "Paint", "Plastic", "Fur", "Scale", "Feather", "Water",
                "Cloud", "Sky", "Space", "Underbelly", "Undercoat", "Snow", "SkyHorizon", "SkyFog",
                "SkyHeightFog", "SkySunset", "SkyNight", "WaterNear", "SpaceCloud", "SpaceBottom", "SpaceSolar", "SpaceLight",
                "Warrior", "Scientific", "Trader", "WarriorAlt", "ScientificAlt", "TraderAlt", "RockSaturated", "RockLight", "RockDark"
            })]
        public GcColourPaletteData[] Palettes;
    }
}
