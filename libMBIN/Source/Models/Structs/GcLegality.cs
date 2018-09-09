namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x5298DB0CDEA42330)]
    public class GcLegality : NMSTemplate
    {

		public enum LegalityEnum { Legal, Illegal, None }
		public LegalityEnum Legality;
    }
}
