using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0x254B258C4FA7BF45, NameHash = 0x6DFF01CC3FB67220)]
    public class TkButtonImageLookup : NMSTemplate
    {
        public List<TkButtonPathMapping> Lookup;
    }
}