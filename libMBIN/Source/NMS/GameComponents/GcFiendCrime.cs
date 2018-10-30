using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1E70826D7D727617)]
    public class GcFiendCrime : NMSTemplate
    {
		public enum FiendCrimeEnum { None, EggDamaged, EggDestroyed, EggCollected, UnderwaterPropDamaged, UnderwaterPropCollected }
		public FiendCrimeEnum FiendCrime;
    }
}
