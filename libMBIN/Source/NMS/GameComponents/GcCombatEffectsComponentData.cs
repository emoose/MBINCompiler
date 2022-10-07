using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82CBA07F9A9EC6C2, NameHash = 0x74FCF5B2A55D262B)]
    public class GcCombatEffectsComponentData : NMSTemplate
    {
        // size: 0x4
        public enum EffectsPropertiesEnum {
            None,
            Fire,
            Stun,
            Slow
        }
        [NMS(Size = 0x4, EnumType = typeof(EffectsPropertiesEnum))]
        /* 0x0 */ public GcCombatEffectsProperties[] EffectsProperties;
    }
}
