using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xFC036F35930AC621, NameHash = 0x83E66770853FCA27)]
    public class GcAlienPuzzleTableIndex : NMSTemplate
    {
		public enum IndexTypeEnum { Regular, Seeded, Random }
		public IndexTypeEnum IndexType;
    }
}