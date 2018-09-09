namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x1B440, GUID = 0x0C4741AF54DADAC92)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new[] { "FloatingIslands", "GrandCanyon", "MountainRavines", "HugeArches", "Alien", "Craters", "Caverns", "Alpine", "LilyPad", "Desert" })]        // TkVoxelGeneratorSettingsTypes
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
