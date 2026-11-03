namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDBA332908BC262F, NameHash = 0xA653F09B)]
    public class GcRewardAtlasPathProgress : NMSTemplate
    {
        // size: 0x3
        public enum AtlasPathProgressTypeEnum : uint {
            IncrementPathProgress,
            FinalStoryAtlas,
            StoreLoopingCompleteStations,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AtlasPathProgressTypeEnum AtlasPathProgressType;
    }
}
