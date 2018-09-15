using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFC036F35930AC621)]
    public class GcAlienPuzzleTableIndex : NMSTemplate
    {
		public enum IndexTypeEnum { Regular, Seeded }
		public IndexTypeEnum IndexType;
    }
}
