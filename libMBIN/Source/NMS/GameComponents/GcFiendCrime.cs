namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99B0B68DDFC1DE47, NameHash = 0xAF90A56B0E99C0CB)]
    public class GcFiendCrime : NMSTemplate
    {
        // size: 0x9
        public enum FiendCrimeEnum {
            None,
            EggDamaged,
            EggDestroyed,
            EggCollected,
            UnderwaterPropDamaged,
            UnderwaterPropCollected,
            RockTransform,
            GroundPropDamage,
            ShotWorm
        }
        /* 0x0 */ public FiendCrimeEnum FiendCrime;
    }
}
