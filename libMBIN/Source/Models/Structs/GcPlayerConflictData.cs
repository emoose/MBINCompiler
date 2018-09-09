namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5CCDC0B70353BB1)]
    public class GcPlayerConflictData : NMSTemplate
    {
		public enum ConflictLevelEnum { Low, Default, High }
		public ConflictLevelEnum ConflictLevel;
    }
}
