using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F0, GUID = 0xA8879B14156D70FE, NameHash = 0x7AA76AD6E14A0C29)]
    public class GcInventoryLayoutGenerationData : NMSTemplate
    {
        [NMS(Size = 0x1F, EnumType = typeof(GcInventoryLayoutSizeType.SizeTypeEnum))]
        public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
