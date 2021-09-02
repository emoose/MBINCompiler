using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x600, GUID = 0x31114F981BFD599E, NameHash = 0x5E68908664819224)]
    public class GcBuildingFilename : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x000 */ public NMSString0x80[] LSystem;
        [NMS(Size = 0x4, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x200 */ public NMSString0x80[] Scene;
        [NMS(Size = 0x4, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x400 */ public NMSString0x80[] WFC;
    }
}
