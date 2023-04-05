using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEF6ECE4D9AD2E6B, NameHash = 0xC9E2EEA2B81DBE00)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Size = 0x36, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0 */ public GcBuildingFilename[] BuildingFiles;
    }
}
