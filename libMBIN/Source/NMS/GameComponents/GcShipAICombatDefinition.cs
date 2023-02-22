using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16D91B292333F7C3, NameHash = 0x27F13746A084A731)]
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
        /* 0x70 */ public NMSString0x10 Shield;
        /* 0x80 */ public NMSString0x10 Gun;
        /* 0x90 */ public int LaserDamageLevel;
        /* 0x94 */ public TkTextureResource Icon;
    }
}
