using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFCDD2DF63DBAF40, NameHash = 0xC9E2EEA2B81DBE00)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Size = 0x34, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0 */ public GcBuildingFilename[] BuildingFiles;
    }
}
