using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5943DFEC116B5B7, NameHash = 0x555E177C27F47DDB)]
    public class GcPlanetColourData : NMSTemplate
    {
        // size: 0x3A
        public enum PalettesEnum {
            Grass,
            Plant,
            Leaf,
            Wood,
            Rock,
            Stone,
            Crystal,
            Sand,
            Dirt,
            Metal,
            Paint,
            Plastic,
            Fur,
            Scale,
            Feather,
            Water,
            Cloud,
            Sky,
            Space,
            Underbelly,
            Undercoat,
            Snow,
            SkyHorizon,
            SkyFog,
            SkyHeightFog,
            SkySunset,
            SkyNight,
            WaterNear,
            SpaceCloud,
            SpaceBottom,
            SpaceSolar,
            SpaceLight,
            Warrior,
            Scientific,
            Trader,
            WarriorAlt,
            ScientificAlt,
            TraderAlt,
            RockSaturated,
            RockLight,
            RockDark,
            PlanetRing,
            Custom_Head,
            Custom_Torso,
            Custom_Chest_Armour,
            Custom_Backpack,
            Custom_Arms,
            Custom_Hands,
            Custom_Legs,
            Custom_Feet,
            Cave,
            GrassAlt,
            BioShip_Body,
            BioShip_Underbelly,
            BioShip_Cockpit,
            SailShip_Sails,
            Freighter,
            FreighterPaint
        }
        [NMS(Size = 0x3A, EnumType = typeof(PalettesEnum))]
        /* 0x0 */ public GcColourPaletteData[] Palettes;
    }
}
