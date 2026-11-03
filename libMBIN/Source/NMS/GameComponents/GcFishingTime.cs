namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x236288951F04858E, NameHash = 0xFC0D407C)]
    public class GcFishingTime : NMSTemplate
    {
        // size: 0x3
        public enum FishingTimeEnum : uint {
            Day,
            Night,
            Both,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FishingTimeEnum FishingTime;
    }
}
