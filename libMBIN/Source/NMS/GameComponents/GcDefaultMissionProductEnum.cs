using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0AD7818FB633DD38)]
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
		public enum DefaultProductTypeEnum { None, PrimaryProduct, SecondaryProduct }
		public DefaultProductTypeEnum DefaultProductType;
    }
}
