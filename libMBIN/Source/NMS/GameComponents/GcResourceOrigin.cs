namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x64987573D6129EB5)]
    public class GcResourceOrigin : NMSTemplate
    {
		public enum ResourceOriginEnum { Terrain, Crystal, Asteroid, Robot, Depot }
		public ResourceOriginEnum ResourceOrigin;
    }
}
