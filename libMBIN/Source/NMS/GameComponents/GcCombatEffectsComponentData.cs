using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F5A56FD6987ACDE, NameHash = 0x1C862912)]
    public class GcCombatEffectsComponentData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcCombatEffectType.CombatEffectTypeEnum))]
        /* 0x0 */ public GcCombatEffectsProperties[] EffectsProperties;
    }
}
