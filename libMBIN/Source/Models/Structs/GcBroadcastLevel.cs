namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8B72D28DF2B25B17)]
    public class GcBroadcastLevel : NMSTemplate
    {
		public enum GalaxyMarkerTypeEnum { Scene, LocalModel, Local }
		public GalaxyMarkerTypeEnum GalaxyMarkerType;
    }
}
