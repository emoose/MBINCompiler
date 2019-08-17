using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xA8, GUID = 0x65ABCF3AAFA3E92D, SubGUID = 0x6A1494CD3EC019B6)]
    public class TkAxisImageLookup : NMSTemplate
    {
        public List<TkAxisPathMapping> Lookup;      // maybe?
    }
}
