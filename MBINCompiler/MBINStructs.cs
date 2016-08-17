using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Xml;
using System.Collections;

namespace MBINCompiler
{
    public class NMSTemplate
    {
        public XmlElement AppendToXml(XmlElement parentElement, XmlDocument document)
        {
            XmlElement el = null;
            if(parentElement != null)
                el = (XmlElement)parentElement.AppendChild(document.CreateElement("Data"));
            else
                el = (XmlElement)document.AppendChild(document.CreateElement("Data"));
            
            var type = GetType();
            el.SetAttribute("template", type.Name);

            var fields = type.GetFields();
            foreach (var field in fields)
            {
                if (field.Name.StartsWith("Padding"))
                    continue;
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;

                switch (fieldType)
                {
                    case "String":
                    case "Single":
                    case "Boolean":
                    case "Int16":
                    case "Int32":
                        var prop = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop.SetAttribute("name", fieldName);
                        var value = field.GetValue(this).ToString();
                        var valuesMethod = type.GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
                        if (valuesMethod != null)
                        {
                            string[] values = (string[])valuesMethod.Invoke(this, null);
                            value = values[(int)field.GetValue(this)];
                        }
                        prop.SetAttribute("value", value);
                        break;
                    case "Byte[]":
                        break; // todo
                    case "List`1":
                        var prop2 = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop2.SetAttribute("name", fieldName);

                        IList templates = (IList)field.GetValue(this);
                        foreach (var template in templates)
                            ((NMSTemplate)template).AppendToXml(prop2, document);

                        break;
                    default:
                        if(field.FieldType.BaseType.Name == "NMSTemplate")
                        {
                            NMSTemplate template = (NMSTemplate)field.GetValue(this);
                            var element = template.AppendToXml(el, document);
                            element.SetAttribute("name", fieldName);
                        }
                        break;
                }
            }

            return el;
        }
    }

    class MBINHeader : NMSTemplate
    {
        public int Magic;
        public int Unknown4;
        public int Unknown8;
        public int UnknownC;
        public long Unknown10;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x48)]
        public string TemplateName;

        public string GetXMLTemplateName()
        {
            if (!TemplateName.StartsWith("c") || TemplateName.Length < 2)
                return TemplateName;

            return TemplateName.Substring(1); // remove the "c" (compiled?) from the start of the template name
        }
    }
   
    public class GcHUDComponent : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public int PosX;
        public int PosY;
        public int Width;
        public int Height;
        public int Align;
        public string[] AlignValues()
        {
            return new string[] { "Center", "TopLeft", "TopRight", "BottomLeft", "BottomRight" };
        }
        public int Unknown24;
    }
    
    public class GcHUDLayerData : NMSTemplate
    {
        public GcHUDComponent Data;
        public List<NMSTemplate> Children;
    }
    
    public class GcHUDImageData : NMSTemplate
    {
        public GcHUDComponent Data;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Image;
        public Colour Colour;
    }

    public class GcTextPreset : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x50)]
        public byte[] Unknown0;
        public float Height;
        public float Unk54;
        public float Unk58;
        public float Unk5C;
        public Colour Colour;
    }

    public class GcHUDTextData : NMSTemplate
    {
        public GcHUDComponent Data;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Text;
        public GcTextPreset Preset;
    }

    public class GcEntitlementRewardData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string EntitlementId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string RewardId;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Error;
    }

    public class GcEntitlementRewardsTable : NMSTemplate
    {
        public List<GcEntitlementRewardData> Table;
    }

    // todo: maybe get rid of this and just read strings directly into the list, if all strings are the same size?
    public class NMSString0x80 : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Value;
    }

    public class NMSString0x10 : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Value;
    }

    public class GcSceneSettings : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x000 */ public string NextSettingFile;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x080 */ public string SceneFile;
        /* 0x100 */ public List<NMSString0x80> PlanetSceneFiles;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x110 */ public string SolarSystemFile;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x190 */ public string PlanetFiles1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x210 */ public string PlanetFiles2;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x290 */ public string PlanetFiles3;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x310 */ public string PlanetFiles4;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x390 */ public string PlanetFiles5;

        /* 0x410 */ public List<NMSString0x80> ShipPreloadFiles;
        /* 0x420 */ public bool SpawnShip;
        /* 0x421 */ public bool SpawnInsideShip;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0xE)]
        /* 0x422 */ public byte[] Padding422;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x50)]
        /* 0x430 */ public byte[] PlayerState; // todo: GcPlayerSpawnStateData

        /* 0x480 */ public List<NMSTemplate> Events;
        /* 0x490 */ public List<NMSTemplate> PostWarpEvents;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x4A0 */ public string SpawnerOptionId;
    }

    public class GcPlanetData : NMSTemplate
    {
        /* 0x000 */ string Name; // 0x80
        /* 0x080 */ int LifeSetting; // Dead / Low / Mid / Full
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x78)]
        /* 0x088 */ public byte[] Hazard; // todo: GcPlanetHazardData
        /* 0x100 */ public int ResourceLevel; // Low / High
        /* 0x104 */ public int BuildingDensity; // todo: GcBuildingDensityLevels
    }

    public class VariableSizeString : NMSTemplate
    {
        public string Value;
    }

    public class GcInventoryType : NMSTemplate
    {
        public int InventoryType; // Substance / Technology / Product
        public string[] InventoryTypeValues()
        {
            return new[] { "Substance", "Technology", "Product" };
        }
    }

    public class GcTechnologyRequirement : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string ID;
        public GcInventoryType InventoryType;
        public int Amount;
    }

    public class GcStatsTypes : NMSTemplate
    {
        public int StatsType; // enum, 0x46 types!
    }

    public class GcStatsBonus : NMSTemplate
    {
        public GcStatsTypes StatsTypes;
        public float Bonus;
        public int Level;
    }

    public class Colour : NMSTemplate
    {
        public float R;
        public float G;
        public float B;
        public float A;
    }

    public class GcTechnology : NMSTemplate
    {
        /* OLD:
        /* 0x1F8 public byte[] Padding1F8; // why is this needed? (probably not, colour must be 0x10 aligned?)
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]
        /* 0x200  public byte[] Colour; // todo: SmallColour type
        */

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x000 */ public string ID; // 0x10
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x010 */ public string Name; // 0x80
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x090 */ public string NameLower; // 0x80
        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        /* 0x130 */ public bool Tech;
       // [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x7)]
        ///* 0x131 */ public byte[] Padding131;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        /* 0x138 */ public string HintStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        /* 0x158 */ public string HintEnd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x178 */ public string IconFilename; // todo: TkTextureResource
        /* 0x200 */ public Colour Colour;
        /* 0x210 */ public int Level;
        /* 0x214 */ public bool Chargeable;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x3)]
        //* 0x215 */ public byte[] Padding215;
        /* 0x218 */ public int ChargeAmount;
        /* 0x21C */ public int SubstanceCategory; // todo: GcRealitySubstanceCategory (Commodity / Technology / Fuel / Tradeable)
        public string[] SubstanceCategoryValues()
        {
            return new[] { "Commodity", "Technology", "Fuel", "Tradeable" };
        }
        /* 0x220 */
        public List<NMSString0x10> ChargeBy;
        /* 0x230 */ public bool BuildFullyCharged;
        /* 0x231 */ public bool Upgrade;
        /* 0x232 */ public bool Core;
        //* 0x233 */ public bool Padding233;
        /* 0x234 */ public int TechnologyCategory; // todo: GcTechnologyCategory (Ship / Weapon / Suit / Personal / All / None)
        public string[] TechnologyCategoryValues()
        {
            return new[] { "Ship", "Weapon", "Suit", "Personal", "All", "None" };
        }
        /* 0x238 */
        public int TechnologyRarity; // todo: GcTechnologyRarity (Normal / VeryCommon / Common / Rare / VeryRare / Impossible / Always)
        public string[] TechnologyRarityValues()
        {
            return new[] { "Normal", "VeryCommon", "Common", "Rare", "VeryRare", "Impossible", "Always" };
        }
        /* 0x23C */
        public float Value;
        /* 0x240 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x250 */ public List<GcStatsBonus> StatBonuses;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x260 */ public string RequiredTech;
        /* 0x270 */ public float RequiredLevel; // todo: is this correct?
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 0xC)]
        //* 0x274 */ public byte[] Padding274;
        /* 0x280 */ public Colour UpgradeColour;
        /* 0x290 */ public Colour LinkColour;

        /*[MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]
        /* 0x280 public byte[] UpgradeColour; // todo: SmallColour type?
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]
        /* 0x290 public byte[] LinkColour; // todo: SmallColour type?*/

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x2A0 */ public string RewardGroup;
    }

    public class GcTechnologyTable : NMSTemplate
    {
        public List<GcTechnology> Table;
    }

    public class GcAlienRace : NMSTemplate
    {
        public int AlienRace;
        public string[] AlienRaceValues()
        {
            return new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "None" };
        }
    }

    public class GcAlienSpeechEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Text;
        public int WordInteractEffect;
        public string[] WordInteractEffectValues()
        {
            return new[] { "Pain", "Heal" };
        }
        public GcAlienRace AlienRace;
        public int Level;
    }

    public class GcAlienSpeechTable : NMSTemplate
    {
        public List<GcAlienSpeechEntry> Table;
    }

    public class GcInteractionType : NMSTemplate
    {
        public int InteractionType; // enum(0x18)
    }

    public class GcAlienPuzzleOption : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        /* 0x000 */ public string Name;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        /* 0x020 */ public string Text;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x220 */ public string Cost;
        /* 0x230 */ public List<NMSString0x10> Rewards;
        /* 0x240 */ public int Mood;
        public string[] MoodValues()
        {
            return new[] { "Positive", "Negative", "Neutral", "Pity" };
        }
        /* 0x244 */ public bool KeepOpen;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Padding;
    }

    public class GcAlienPuzzleEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public GcAlienRace AlienRace;
        public GcInteractionType InteractionType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        public string Text;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x200)]
        public string TextAlien;
        public bool TranslateAlienText;
        public List<GcAlienPuzzleOption> Options;
    }

    public class GcAlienPuzzleTable : NMSTemplate
    {
        public List<GcAlienPuzzleEntry> Table;
    }

    public class TkPaletteTexture : NMSTemplate
    {
        public int Palette; // enum(0x26)
        public int ColourAlt;
        public string[] ColourAltValues()
        {
            return new[] { "Primary", "Alternative1", "Alternative2", "Alternative3", "Alternative4", "Unique", "MatchGround", "None" };
        }
    }

    public class GcHeavyAirSettingValues : NMSTemplate
    {
        public float Thickness;
        public float Speed;
        public float Alpha1;
        public float Alpha2;
        public TkPaletteTexture Colour1;
        public TkPaletteTexture Colout2;
    }

    public class GcHeavyAirSetting : NMSTemplate
    {
        // todo: GcHeavyAirSettingValues[] instead
        public GcHeavyAirSettingValues Settings1;
        public GcHeavyAirSettingValues Settings2;
        public GcHeavyAirSettingValues Settings3;
        public GcHeavyAirSettingValues Settings4;
        public GcHeavyAirSettingValues Settings5;
    }
    public class GcFogProperties : NMSTemplate
    {
        public float FogStrength;
        public float FogMax;
        public float FogColourStrength;
        public float FogColourMax;
        public float HeightFogStrength;
        public float HeightFogFadeOutStrength;
        public float HeightFogOffset;
        public float HeightFogMax;
        public float FogHeight;
        public GcHeavyAirSetting HeavyAirSettings;
        public float CloudRatio;
        public float FullscreenEffect;
        public float DepthOfField;
        public float DepthOfFieldDistance;
        public float DepthOfFieldFade;
        public bool IsRaining;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x3)]
        public byte[] Padding;
    }

    public class GcColourModifier : NMSTemplate
    {
        public bool ForceColour;
        public Colour ForceColourTo;
        public float OffsetSaturation;
        public float OffsetValue;
        public float MultiplySaturation;
        public float MultiplyValue;
    }

    public class GcWeatherColourModifiers : NMSTemplate
    {
        public GcColourModifier SkyColour;
        public GcColourModifier HorizonColour;
        public GcColourModifier SunColour;
        public GcColourModifier FogColour;
        public GcColourModifier HeightFogColour;
        public GcColourModifier LightColour;
        public GcColourModifier CloudColour1;
        public GcColourModifier CloudColour2;

        // todo: change this to array
        public GcColourModifier HeavyAirColour1;
        public GcColourModifier HeavyAirColour2;
        public GcColourModifier HeavyAirColour3;
        public GcColourModifier HeavyAirColour4;
        public GcColourModifier HeavyAirColour5;
    }

    public class GcHazardValues : NMSTemplate
    {
        public float Min;
        public float Max;
    }

    public class GcWeatherProperties : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Name;

        public GcFogProperties Fog;
        public GcFogProperties FlightFog;
        public GcFogProperties StormFog;
        public GcFogProperties ExtremeFog;

        public GcWeatherColourModifiers StormColourModifiers;
        public GcWeatherColourModifiers ExtremeColourModifiers;

        public List<NMSString0x80> HeavyAir;

        public float LowStormsChance;
        public float HighStormsChance;
        public float ExtremeWeatherChance;

        public bool OverrideTemperature;
        public GcHazardValues Temperature1;
        public GcHazardValues Temperature2;
        public GcHazardValues Temperature3;
        public GcHazardValues Temperature4;
        public GcHazardValues Temperature5;

        public bool OverrideToxicity;
        public GcHazardValues Toxicity1;
        public GcHazardValues Toxicity2;
        public GcHazardValues Toxicity3;
        public GcHazardValues Toxicity4;
        public GcHazardValues Toxicity5;

        public bool OverrideRadiation;
        public GcHazardValues Radiation1;
        public GcHazardValues Radiation2;
        public GcHazardValues Radiation3;
        public GcHazardValues Radiation4;
        public GcHazardValues Radiation5;
    }

    public class GcPlanetWeatherColourData : NMSTemplate
    {
        public Colour SkyColour;
        public Colour SkyUpperColour;
        public Colour SkySolarColour;
        public Colour HorizonColour;
        public Colour SunColour;
        public Colour FogColour;
        public Colour HeightFogColour;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10)]
        public byte[] SkyGradientSpeed; // not sure what type this is?

        public Colour LightColour;
        public Colour CloudColour1;
        public Colour CloudColour2;
    }

    public class GcWeatherColourSettingList : NMSTemplate
    {
        public List<GcPlanetWeatherColourData> Settings;
    }

    public class TkLocalisationEntry : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Id;

        public VariableSizeString English;
        public VariableSizeString French;
        public VariableSizeString Italian;
        public VariableSizeString German;
        public VariableSizeString Spanish;
        public VariableSizeString Russian;
        public VariableSizeString Polish;
        public VariableSizeString Dutch;
        public VariableSizeString Portuguese;
        public VariableSizeString LatinAmericanSpanish;
        public VariableSizeString BrazilianPortuguese;
        public VariableSizeString SimplifiedChinese;
        public VariableSizeString TraditionalChinese;
        public VariableSizeString Korean;
        public VariableSizeString Japanese;
        public VariableSizeString USEnglish;
    }

    public class TkLocalisationTable : NMSTemplate
    {
        public List<TkLocalisationEntry> Table;
    }

    public class GcCreatureStupidName : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Id;
        public int Count;
        public List<NMSString0x80> Names;
    }

    public class GcCreatureStupidNameTable : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string StupidUserName;

        public List<GcCreatureStupidName> Table;
    }

    public class TkProceduralTexture : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Name;
        public TkPaletteTexture Palette;
        public float Probability;
        public int TextureGameplayUse;
        public string[] TextureGameplayUseValues()
        {
            return new[] { "IgnoreName", "MatchName", "DoNotMatchName" };
        }
        public bool OverrideAverageColour;
        public Colour AverageColour;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Diffuse;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Normal;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        public string Mask;
    }

    public class TkProceduralTextureLayer : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Name;
        public float Probability;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Group;
        public bool SelectToMatchBase;
        public List<TkProceduralTexture> Textures;
    }

    public class TkProceduralTextureList : NMSTemplate
    {
        public TkProceduralTextureLayer Layer1;
        public TkProceduralTextureLayer Layer2;
        public TkProceduralTextureLayer Layer3;
        public TkProceduralTextureLayer Layer4;
        public TkProceduralTextureLayer Layer5;
        public TkProceduralTextureLayer Layer6;
        public TkProceduralTextureLayer Layer7;
        public TkProceduralTextureLayer Layer8;
    }
}
