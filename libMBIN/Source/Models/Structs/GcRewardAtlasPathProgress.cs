namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x40F3E6BA599AC188)]
    public class GcRewardAtlasPathProgress : NMSTemplate
    {
		public enum AtlasPathProgressTypeEnum { IncrementPathProgress, FinalStoryAtlas }
		public AtlasPathProgressTypeEnum AtlasPathProgressType;
    }
}
