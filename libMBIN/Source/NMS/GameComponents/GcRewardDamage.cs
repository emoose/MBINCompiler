using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E5E6AD970D10563, NameHash = 0xBF831730)]
    public class GcRewardDamage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcImpactCombatEffectData> CombatEffects;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 PlayerDamage;
    }
}
