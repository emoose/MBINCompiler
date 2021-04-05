using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x82EAF2218E0F4C34, NameHash = 0x1037140D8873D8ED)]
    public class GcWiki : NMSTemplate
    {
        public List<GcWikiCategory> Categories;
    }
}
