using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39909746491EA7AA, NameHash = 0x4742E3FE43A533C7)]
    public class GcCreatureGenerationData : NMSTemplate
    {
        // size: 0x10
        public enum BiomeSpecificEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(BiomeSpecificEnum))]
        /* 0x000 */ public GcCreatureGenerationOptionalWeightedList[] BiomeSpecific;
        // size: 0x1B
        public enum SubBiomeSpecificEnum {
            None,
            Standard,
            HighQuality,
            Structure,
            Beam,
            Hexagon,
            FractCube,
            Bubble,
            Shards,
            Contour,
            Shell,
            BoneSpire,
            WireCell,
            HydroGarden,
            HugePlant,
            HugeLush,
            HugeRing,
            HugeRock,
            HugeScorch,
            HugeToxic,
            Variant_A,
            Variant_B,
            Variant_C,
            Variant_D,
            Infested,
            Swamp,
            Lava
        }
        [NMS(Size = 0x1B, EnumType = typeof(SubBiomeSpecificEnum))]
        /* 0x480 */ public GcCreatureGenerationOptionalWeightedList[] SubBiomeSpecific;
        /* 0xC18 */ public GcCreatureGenerationOptionalWeightedList AbandonedSystemSpecific;
        /* 0xC60 */ public GcCreatureGenerationOptionalWeightedList EmptySystemSpecific;
        /* 0xCA8 */ public GcCreatureGenerationWeightedList Generic;
        /* 0xCE8 */ public List<GcCreatureGenerationWeightedListDomainEntry> AirArchetypesForEmptyGround;
        // size: 0x10
        public enum SandwormPresenceChanceEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(SandwormPresenceChanceEnum))]
        /* 0xCF8 */ public float[] SandwormPresenceChance;
        // size: 0x4
        public enum LifeChanceEnum {
            Dead,
            Low,
            Mid,
            Full
        }
        [NMS(Size = 0x4, EnumType = typeof(LifeChanceEnum))]
        /* 0xD38 */ public float[] LifeChance;
        // size: 0x4
        public enum RoleFrequencyModifiersEnum {
            Never,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(RoleFrequencyModifiersEnum))]
        /* 0xD48 */ public float[] RoleFrequencyModifiers;
        // size: 0x4
        public enum RarityFrequencyModifiersEnum {
            Common,
            Uncommon,
            Rare,
            SuperRare
        }
        [NMS(Size = 0x4, EnumType = typeof(RarityFrequencyModifiersEnum))]
        /* 0xD58 */ public float[] RarityFrequencyModifiers;
        // size: 0x4
        public enum GroundGroupsPerKmEnum {
            Sparse,
            Normal,
            Dense,
            VeryDense
        }
        [NMS(Size = 0x4, EnumType = typeof(GroundGroupsPerKmEnum))]
        /* 0xD68 */ public float[] GroundGroupsPerKm;
        // size: 0x4
        public enum WaterGroupsPerKmEnum {
            Sparse,
            Normal,
            Dense,
            VeryDense
        }
        [NMS(Size = 0x4, EnumType = typeof(WaterGroupsPerKmEnum))]
        /* 0xD78 */ public float[] WaterGroupsPerKm;
        // size: 0x4
        public enum AirGroupsPerKmEnum {
            Sparse,
            Normal,
            Dense,
            VeryDense
        }
        [NMS(Size = 0x4, EnumType = typeof(AirGroupsPerKmEnum))]
        /* 0xD88 */ public float[] AirGroupsPerKm;
        // size: 0x4
        public enum CaveGroupsPerKmEnum {
            Sparse,
            Normal,
            Dense,
            VeryDense
        }
        [NMS(Size = 0x4, EnumType = typeof(CaveGroupsPerKmEnum))]
        /* 0xD98 */ public float[] CaveGroupsPerKm;
        // size: 0x4
        public enum DensityModifiersEnum {
            Sparse,
            Normal,
            Dense,
            VeryDense
        }
        [NMS(Size = 0x4, EnumType = typeof(DensityModifiersEnum))]
        /* 0xDA8 */ public float[] DensityModifiers;
        // size: 0x4
        public enum LifeLevelDensityModifiersEnum {
            Dead,
            Low,
            Mid,
            Full
        }
        [NMS(Size = 0x4, EnumType = typeof(LifeLevelDensityModifiersEnum))]
        /* 0xDB8 */ public float[] LifeLevelDensityModifiers;
        /* 0xDC8 */ public float HerdCreaturePenalty;
    }
}
