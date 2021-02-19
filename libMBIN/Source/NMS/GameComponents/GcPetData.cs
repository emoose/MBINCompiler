using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF0, GUID = 0xF0423B6C549ED07F, NameHash = 0x995CD6C5BC075C98)]
    public class GcPetData : NMSTemplate
    {
        /* 0x00 */ public float Scale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string CreatureID;
        /* 0x18 */ public List<NMSString0x20> Descriptors;
        /* 0x28 */ public GcSeed CreatureSeed;
        /* 0x38 */ public GcSeed CreatureSecondarySeed;
        /* 0x48 */ public ulong SpeciesSeed;
        /* 0x50 */ public ulong GenusSeed;
        /* 0x58 */ public bool Predator;
        /* 0x60 */ public ulong UA;
        /* 0x68 */ public GcSeed ColourBaseSeed;
        /* 0x78 */ public GcSeed BoneScaleSeed;
        /* 0x88 */ public GcBiomeType Biome;
        /* 0x8C */ public GcCreatureTypes CreatureType;
        /* 0x90 */ public ulong BirthTime;
        /* 0x98 */ public ulong LastEggTime;
        /* 0xA0 */ public ulong LastTrustIncreaseTime;
        /* 0xA8 */ public ulong LastTrustDecreaseTime;
        /* 0xB0 */ public bool EggModified;
        /* 0xB1 */ public bool HasBeenSummoned;
        [NMS(Size = 0x20)]
        /* 0xB2 */ public string CustomName;
        /* 0xD4 */ public float Trust;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitsEnum))]
        /* 0xD8 */ public float[] Traits;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0xE4 */ public float[] Moods;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xEC */ public byte[] EndPadding;
    }
}