using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBDA143CC1ACA7E82, NameHash = 0x62EA167F11DA4F86)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Size = 0x15, EnumType = typeof(TkVoxelGeneratorSettingsTypes.TerrainSettingsEnum))]
        /* 0x0 */ public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
