using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x547C3CBA03DF29F0, NameHash = 0xC0D06960)]
    public class GcCreatureData : NMSTemplate
    {
        [NMS(Index = 19)]
        /* 0x00 */ public List<NMSTemplate> Data;
        [NMS(Index = 18)]
        /* 0x10 */ public NMSString0x10 EggType;
        [NMS(Index = 27)]
        /* 0x20 */ public List<GcPetBattlerFlyerOffsetOverride> FlyerOffsetOverrides;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Id;
        [NMS(Index = 17)]
        /* 0x40 */ public NMSString0x10 KillingBlowMessageID;
        [NMS(Index = 16)]
        /* 0x50 */ public NMSString0x10 KillStatID;
        [NMS(Index = 28)]
        /* 0x60 */ public List<GcPetBattlerMoveSetSelection> MoveSets;
        [NMS(Index = 26)]
        /* 0x70 */ public List<VariableSizeString> PetBattlerNodesToHide;
        [NMS(Index = 6)]
        /* 0x80 */ public List<GcCreatureTagAndRarity> Tags;
        [NMS(Index = 2)]
        /* 0x90 */ public GcCreatureTypes ForceType;
        [NMS(Index = 12)]
        /* 0x94 */ public float FurChance;
        [NMS(Index = 11)]
        /* 0x98 */ public float FurLengthModifierAtMaxScale;
        [NMS(Index = 10)]
        /* 0x9C */ public float FurLengthModifierAtMinScale;
        [NMS(Index = 15)]
        /* 0xA0 */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;
        [NMS(Index = 9)]
        /* 0xA4 */ public float MaxScale;
        [NMS(Index = 8)]
        /* 0xA8 */ public float MinScale;
        // size: 0x4
        public enum MoveAreaEnum : uint {
            Ground,
            Water,
            Air,
            Space,
        }
        [NMS(Index = 7)]
        /* 0xAC */ public MoveAreaEnum MoveArea;
        [NMS(Index = 23)]
        /* 0xB0 */ public float PetBattleFlyerExtraOffset;
        [NMS(Index = 22)]
        /* 0xB4 */ public float PetBattlerSelectionWeight;
        [NMS(Index = 20)]
        /* 0xB8 */ public GcGameTablePetTag PetBattlerTags;
        [NMS(Index = 14)]
        /* 0xBC */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        [NMS(Index = 13)]
        /* 0xC0 */ public GcCreatureRarity Rarity;
        [NMS(Index = 3)]
        /* 0xC4 */ public GcCreatureTypes RealType;
        [NMS(Index = 5)]
        /* 0xC8 */ public bool CanBeFemale;
        [NMS(Index = 21)]
        /* 0xC9 */ public bool CanBeUsedInPetBattler;
        [NMS(Index = 4)]
        /* 0xCA */ public bool EcoSystemCreature;
        [NMS(Index = 1)]
        /* 0xCB */ public bool OnlySpawnWhenIdIsForced;
        [NMS(Index = 24)]
        /* 0xCC */ public GcPetBattlerAffinity PetBattlerForcedAffinity;
        [NMS(Index = 25)]
        /* 0xCD */ public bool PetBattlerShouldSwellOnAttack;
    }
}
