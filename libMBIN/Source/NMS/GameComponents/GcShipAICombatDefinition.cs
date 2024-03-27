using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57AA65E33D1B7E3, NameHash = 0x27F13746A084A731)]
    public class GcShipAICombatDefinition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 Behaviour;
        /* 0x20 */ public NMSString0x10 PlanetBehaviour;
        /* 0x30 */ public NMSString0x10 Engine;
        /* 0x40 */ public NMSString0x10 PlanetEngine;
        /* 0x50 */ public NMSString0x10 Reward;
        /* 0x60 */ public int RewardCount;
        /* 0x64 */ public int Health;
        /* 0x68 */ public int LevelledExtraHealth;
        /* 0x70 */ public NMSString0x10 DamageMultiplier;
        /* 0x80 */ public NMSString0x10 Shield;
        /* 0x90 */ public bool UsesShieldGenerators;
        /* 0x91 */ public bool UsesFuelRods;
        /* 0x98 */ public NMSString0x10 Gun;
        /* 0xA8 */ public int LaserDamageLevel;
        /* 0xAC */ public TkTextureResource Icon;
    }
}
