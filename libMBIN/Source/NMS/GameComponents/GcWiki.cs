using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0E134803BA9DF6A6F)]
    public class GcWiki : NMSTemplate
    {
        public List<GcWikiCategory> Categories;
    }
}
