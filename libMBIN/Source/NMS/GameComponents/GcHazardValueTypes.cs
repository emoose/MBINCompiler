namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6250923D23A199CE, NameHash = 0x8B58B508)]
    public class GcHazardValueTypes : NMSTemplate
    {
        // size: 0x6
        public enum HazardValueEnum : uint {
            Ambient,
            Water,
            Cave,
            Storm,
            Night,
            DeepWater,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardValueEnum HazardValue;
    }
}
