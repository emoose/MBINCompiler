namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x38B1146A8FA37504, NameHash = 0xDF72B6BAF8A085A2)]
    public class TkNoiseLayersEnum : NMSTemplate
    {
        // size: 0x8
        public enum NoiseLayerTypesEnum {
            Base,
            Hill,
            Mountain,
            Rock,
            UnderWater,
            Texture,
            Elevation,
            Continent
        }
        /* 0x0 */ public NoiseLayerTypesEnum NoiseLayerTypes;
    }
}
