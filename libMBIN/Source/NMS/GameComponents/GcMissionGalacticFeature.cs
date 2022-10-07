namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6EBBD7E6C55765C, NameHash = 0x60EEF97D074917CD)]
    public class GcMissionGalacticFeature : NMSTemplate
    {
        // size: 0x3
        public enum GalacticFeatureEnum {
            Anomaly,
            Atlas,
            BlackHole
        }
        /* 0x0 */ public GalacticFeatureEnum GalacticFeature;
    }
}
