using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xED4FE89BE3CD4FF5, SubGUID = 0x6DFF01CC3FB67220)]
    public class TkButtonImageLookup : NMSTemplate
    {
        public List<TkButtonPathMapping> Lookup;
    }
}
