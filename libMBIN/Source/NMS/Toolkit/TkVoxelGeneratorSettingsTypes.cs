using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x4, GUID = 0x9EE55190D40B0D6A, NameHash = 0x60B0A451EF1759F9)]
    public class TkVoxelGeneratorSettingsTypes : NMSTemplate
    {
        public enum TerrainSettingsEnum { FloatingIslands, GrandCanyon, MountainRavines, HugeArches, Alien, Craters, Caverns, Alpine, LilyPad, Desert }
        public TerrainSettingsEnum TerrainSettings;
    }
}