using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x4F3FAE85B4AF62AF)]
    public class GcLegacyItemTable : NMSTemplate
    {
		/* 0x00 */ public List<GcLegacyItem> Table;
    }
}
