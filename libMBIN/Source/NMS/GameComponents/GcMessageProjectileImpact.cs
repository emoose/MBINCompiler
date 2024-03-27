using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF66E462C127861F, NameHash = 0x7EBC25FE326CF24B)]
    public class GcMessageProjectileImpact : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Damage;
        /* 0x14 */ public GcDamageType Type;
        /* 0x18 */ public bool Critical;
        /* 0x19 */ public bool Ineffective;
        /* 0x1A */ public bool LaserHeatBoost;
        /* 0x1C */ public GcNodeID Node;
        // size: 0x3
        public enum HitTypeEnum : uint {
            Shootable,
            Terrain,
            Generic,
        }
        /* 0x20 */ public HitTypeEnum HitType;
        /* 0x30 */ public Vector3f PosLocal;
        /* 0x40 */ public Vector3f PosOffset;
        /* 0x50 */ public List<GcImpactCombatEffectData> CombatEffects;
        /* 0x60 */ public List<GcCombatEffectDamageMultiplier> DamageMultipliers;
    }
}
