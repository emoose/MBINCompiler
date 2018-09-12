namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x90F243C3F9529DB6)]
    public class GcPrimaryAxis : NMSTemplate
    {
		public enum PrimaryAxisEnum { Z, ZNeg }
		public PrimaryAxisEnum PrimaryAxis;
    }
}
