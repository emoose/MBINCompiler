namespace MBINCompiler.Models.Structs
{
    public class GcRewardAtlasPathProgress : NMSTemplate
    {
        public int AtlasPathProgressType;
        public string[] AtlasPathProgressTypeValues()
        {
            return new[] { "IncrementPathProgress", "FinalStoryAtlas" };
        }
    }
}
