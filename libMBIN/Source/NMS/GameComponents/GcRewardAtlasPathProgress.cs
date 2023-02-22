namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29D761D8EFF76D18, NameHash = 0x2FFD5C572426F075)]
    public class GcRewardAtlasPathProgress : NMSTemplate
    {
        // size: 0x2
        public enum AtlasPathProgressTypeEnum {
            IncrementPathProgress,
            FinalStoryAtlas,
        }
        /* 0x0 */ public AtlasPathProgressTypeEnum AtlasPathProgressType;
    }
}
