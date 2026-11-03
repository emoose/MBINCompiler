using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB2A389E6519564C4, NameHash = 0x2155C565)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1F, EnumType = typeof(TkVoxelGeneratorSettingsTypes.TerrainSettingsEnum))]
        /* 0x0 */ public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
