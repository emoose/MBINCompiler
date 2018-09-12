using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0AD7818FB633DD38)]
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
		public enum DefaultProductTypeEnum { None, PrimaryProduct, SecondaryProduct }
		public DefaultProductTypeEnum DefaultProductType;
    }
}
