namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCEEA023BD8FB18B7, NameHash = 0xA54BFECBD79D65EE)]
    public class TkNoiseVoxelTypeEnum : NMSTemplate
    {
        // size: 0xA
        public enum NoiseVoxelTypeEnum {
            Base,
            Rock,
            Mountain,
            Sand,
            Cave,
            Substance_1,
            Substance_2,
            Substance_3,
            RandomRock,
            RandomRockOrSubstance
        }
        /* 0x0 */ public NoiseVoxelTypeEnum NoiseVoxelType;
    }
}
