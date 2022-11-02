namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED77C82D8D0AA021, NameHash = 0x5E68908664819224)]
    public class GcBuildingFilename : NMSTemplate
    {
        [NMS(Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x000 */ public NMSString0x80[] LSystem;
        [NMS(Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x100 */ public NMSString0x80[] Scene;
        [NMS(Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x200 */ public NMSString0x80[] WFC;
    }
}
