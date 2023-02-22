namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE79BCB8D53D9B2C0, NameHash = 0xCC36FE8AD202DF8)]
    public class GcCombatEffectType : NMSTemplate
    {
        // size: 0x4
        public enum CombatEffectTypeEnum {
            None,
            Fire,
            Stun,
            Slow,
        }
        /* 0x0 */ public CombatEffectTypeEnum CombatEffectType;
    }
}
