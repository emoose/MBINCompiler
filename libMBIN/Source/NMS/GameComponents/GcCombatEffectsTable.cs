using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5ABD7317C241A7D6, NameHash = 0x733D7A989F8B9969)]
    public class GcCombatEffectsTable : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcCombatEffectType.CombatEffectTypeEnum))]
        /* 0x0 */ public GcCombatEffectData[] EffectsData;
    }
}
