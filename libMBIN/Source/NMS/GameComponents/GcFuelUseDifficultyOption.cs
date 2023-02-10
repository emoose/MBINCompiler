namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3CCFBD50DD8764D, NameHash = 0x920A215A167E01E2)]
    public class GcFuelUseDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum FuelUseDifficultyEnum {
            Free,
            Cheap,
            Normal,
            Expensive,
        }
        /* 0x0 */ public FuelUseDifficultyEnum FuelUseDifficulty;
    }
}
