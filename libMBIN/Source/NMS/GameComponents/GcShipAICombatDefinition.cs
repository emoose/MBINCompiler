using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x111E6150CDDDBBFD, NameHash = 0xE9D08BD5)]
    public class GcShipAICombatDefinition : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 1)]
        /* 0x18 */ public NMSString0x10 Behaviour;
        [NMS(Index = 10)]
        /* 0x28 */ public NMSString0x10 DamageMultiplier;
        [NMS(Index = 3)]
        /* 0x38 */ public NMSString0x10 Engine;
        [NMS(Index = 14)]
        /* 0x48 */ public NMSString0x10 Gun;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x68 */ public NMSString0x10 PlanetBehaviour;
        [NMS(Index = 4)]
        /* 0x78 */ public NMSString0x10 PlanetEngine;
        [NMS(Index = 5)]
        /* 0x88 */ public NMSString0x10 Reward;
        [NMS(Index = 11)]
        /* 0x98 */ public NMSString0x10 Shield;
        [NMS(Index = 17)]
        /* 0xA8 */ public float AutofollowDistance;
        [NMS(Index = 9)]
        /* 0xAC */ public float CapOneShotDamagePercent;
        [NMS(Index = 7)]
        /* 0xB0 */ public int Health;
        [NMS(Index = 15)]
        /* 0xB4 */ public int LaserDamageLevel;
        [NMS(Index = 8)]
        /* 0xB8 */ public int LevelledExtraHealth;
        [NMS(Index = 6)]
        /* 0xBC */ public int RewardCount;
        [NMS(Index = 13)]
        /* 0xC0 */ public bool UsesFuelRods;
        [NMS(Index = 12)]
        /* 0xC1 */ public bool UsesShieldGenerators;
    }
}
