namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFB5C1D095031D0FA, NameHash = 0x13CA2ECC)]
    public class TkNoiseLayersEnum : NMSTemplate
    {
        // size: 0x8
        public enum NoiseLayerTypesEnum : uint {
            Base,
            Hill,
            Mountain,
            Rock,
            UnderWater,
            Texture,
            Elevation,
            Continent,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NoiseLayerTypesEnum NoiseLayerTypes;
    }
}
