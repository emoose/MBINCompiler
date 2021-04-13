using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x0000000000000000, NameHash = 0xAF90A56B0E99C0CB)]
    public class GcFiendCrime : NMSTemplate
    {
        // length: 0x8
		public enum FiendCrimeEnum {
            None, EggDamaged, EggDestroyed, EggCollected, UnderwaterPropDamaged, UnderwaterPropCollected, RockTransform, GroundPropDamage
        }
		public FiendCrimeEnum FiendCrime;
    }
}
