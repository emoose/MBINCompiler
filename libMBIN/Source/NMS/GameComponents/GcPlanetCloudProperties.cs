namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x317CC475080CF8F1, NameHash = 0x96E42AD217EA55B2)]
    public class GcPlanetCloudProperties : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public float Coverage1;
        /* 0x14 */ public float Coverage2;
        /* 0x18 */ public float Coverage3;
        /* 0x1C */ public float Offset1;
        /* 0x20 */ public float Offset2;
        /* 0x24 */ public float Offset3;
        /* 0x28 */ public Vector2f CoverExtremes;
        /* 0x30 */ public float Ratio;
        /* 0x34 */ public float RateOfChange;
        /* 0x38 */ public float SecondaryRateOfChange;
        // size: 0x2
        public enum CloudinessEnum {
            CloudyWithClearSpells,
            ClearWithCloudySpells
        }
        /* 0x3C */ public CloudinessEnum Cloudiness;
    }
}
