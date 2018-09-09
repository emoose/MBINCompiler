namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D43AF1D3C4E374FD)]
    public class GcNetworkInterpolationComponentData : NMSTemplate
    {
		public enum SynchroniseScaleEnum { Never, Once, Always }
		public SynchroniseScaleEnum SynchroniseScale;
    }
}
