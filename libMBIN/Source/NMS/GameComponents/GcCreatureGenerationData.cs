using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96122CA68225C5C1, NameHash = 0x1BA21E88)]
    public class GcCreatureGenerationData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x20, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum), MxmlName = "SubBiomeSpecific ")]
        /* 0x000 */ public GcCreatureGenerationOptionalWeightedList[] SubBiomeSpecific;
        [NMS(Index = 0, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum), MxmlName = "BiomeSpecific ")]
        /* 0x900 */ public GcCreatureGenerationOptionalWeightedList[] BiomeSpecific;
        [NMS(Index = 2)]
        /* 0xDC8 */ public GcCreatureGenerationOptionalWeightedList AbandonedSystemSpecific;
        [NMS(Index = 3)]
        /* 0xE10 */ public GcCreatureGenerationOptionalWeightedList EmptySystemSpecific;
        [NMS(Index = 4)]
        /* 0xE58 */ public GcCreatureGenerationOptionalWeightedList PurpleSystemSpecific;
        [NMS(Index = 5)]
        /* 0xEA0 */ public GcCreatureGenerationWeightedList Generic;
        [NMS(Index = 6)]
        /* 0xEE0 */ public List<GcCreatureGenerationWeightedListDomainEntry> AirArchetypesForEmptyGround;
        [NMS(Index = 7, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xEF0 */ public float[] SandwormPresenceChance;
        [NMS(Index = 13, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xF34 */ public float[] AirGroupsPerKm;
        [NMS(Index = 14, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xF44 */ public float[] CaveGroupsPerKm;
        [NMS(Index = 15, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xF54 */ public float[] DensityModifiers;
        [NMS(Index = 11, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xF64 */ public float[] GroundGroupsPerKm;
        [NMS(Index = 8, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0xF74 */ public float[] LifeChance;
        [NMS(Index = 16, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0xF84 */ public float[] LifeLevelDensityModifiers;
        [NMS(Index = 10, Size = 0x4, EnumType = typeof(GcCreatureRarity.CreatureRarityEnum))]
        /* 0xF94 */ public float[] RarityFrequencyModifiers;
        [NMS(Index = 9, Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0xFA4 */ public float[] RoleFrequencyModifiers;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcCreatureGenerationDensity.DensityEnum))]
        /* 0xFB4 */ public float[] WaterGroupsPerKm;
        [NMS(Index = 17)]
        /* 0xFC4 */ public float HerdCreaturePenalty;
    }
}
