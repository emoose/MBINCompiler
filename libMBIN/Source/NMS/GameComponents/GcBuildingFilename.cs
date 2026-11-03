using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x560712B3429DE469, NameHash = 0x253868ED)]
    public class GcBuildingFilename : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x00 */ public GcFilename[] LSystem;
        [NMS(Index = 1, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x20 */ public GcFilename[] Scene;
        [NMS(Index = 2, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x40 */ public GcFilename[] WFC;
    }
}
