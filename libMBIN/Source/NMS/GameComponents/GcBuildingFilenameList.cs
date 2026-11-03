using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD5A661F154FE00A, NameHash = 0x7322E012)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0 */ public GcBuildingFilename[] BuildingFiles;
    }
}
