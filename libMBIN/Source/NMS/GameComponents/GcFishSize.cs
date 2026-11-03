namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8385A23CE6F0B88, NameHash = 0x52B3609)]
    public class GcFishSize : NMSTemplate
    {
        // size: 0x4
        public enum FishSizeEnum : uint {
            Small,
            Medium,
            Large,
            ExtraLarge,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FishSizeEnum FishSize;
    }
}
