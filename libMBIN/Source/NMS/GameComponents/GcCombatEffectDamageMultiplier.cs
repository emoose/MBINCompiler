using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34F62267AAEED232, NameHash = 0x2C5D102E)]
    public class GcCombatEffectDamageMultiplier : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        [NMS(Index = 1)]
        /* 0x4 */ public float DamageMultiplier;
    }
}
