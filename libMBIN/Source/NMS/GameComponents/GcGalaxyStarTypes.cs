namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x30093440ED31F004)]
    public class GcGalaxyStarTypes : NMSTemplate
    {
		public enum GalaxyStarTypeEnum { Yellow, Green, Blue, Red }
		public GalaxyStarTypeEnum GalaxyStarType;
    }
}
