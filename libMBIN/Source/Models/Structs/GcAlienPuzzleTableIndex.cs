namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0FC036F35930AC621)]
    public class GcAlienPuzzleTableIndex : NMSTemplate
    {
		public enum IndexTypeEnum { Regular, Seeded }
		public IndexTypeEnum IndexType;
    }
}
