namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0B6EBBD7E6C55765C)]
    public class GcMissionGalacticFeature : NMSTemplate
    {
		public enum GalacticFeatureEnum { Anomaly, Atlas, BlackHole }
		public GalacticFeatureEnum GalacticFeature;
    }
}
