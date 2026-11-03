namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE26E00CBBAD7D87F, NameHash = 0xADE60E03)]
    public class GcCombatEffectType : NMSTemplate
    {
        // size: 0x6
        public enum CombatEffectTypeEnum : uint {
            None,
            Fire,
            Stun,
            Slow,
            ElectricDOT,
            SpookyLight,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CombatEffectTypeEnum CombatEffectType;
    }
}
