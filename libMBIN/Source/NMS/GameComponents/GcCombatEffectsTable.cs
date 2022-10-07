using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1D29A21F8B10B74, NameHash = 0x733D7A989F8B9969)]
    public class GcCombatEffectsTable : NMSTemplate
    {
        // size: 0x4
        public enum EffectsDataEnum {
            None,
            Fire,
            Stun,
            Slow
        }
        [NMS(Size = 0x4, EnumType = typeof(EffectsDataEnum))]
        /* 0x0 */ public GcCombatEffectData[] EffectsData;
    }
}
