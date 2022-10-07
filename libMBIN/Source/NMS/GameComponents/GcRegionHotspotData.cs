namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4407DD0C57805BE6, NameHash = 0x36E137A2EA118340)]
    public class GcRegionHotspotData : NMSTemplate
    {
        /* 0x00 */ public float ProbabilityWeighting;
        /* 0x04 */ public float MinRange;
        /* 0x08 */ public float MaxRange;
        // size: 0x4
        public enum ClassWeightingsEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(ClassWeightingsEnum))]
        /* 0x0C */ public float[] ClassWeightings;
        // size: 0x4
        public enum ClassStrengthsEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(ClassStrengthsEnum))]
        /* 0x1C */ public float[] ClassStrengths;
        /* 0x2C */ public float DiscoveryDistanceThreshold;
    }
}
