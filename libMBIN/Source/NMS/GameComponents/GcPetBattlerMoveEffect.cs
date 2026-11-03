namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8ED94686EF585C7, NameHash = 0xFB20F273)]
    public class GcPetBattlerMoveEffect : NMSTemplate
    {
        // size: 0xA
        public enum PetBattlerMoveEffectEnum : uint {
            None,
            DamageNoProjectile,
            Projectile,
            Buff,
            Debuff,
            DoTDamage,
            Heal,
            Shield,
            SwapPet,
            Stun,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBattlerMoveEffectEnum PetBattlerMoveEffect;
    }
}
