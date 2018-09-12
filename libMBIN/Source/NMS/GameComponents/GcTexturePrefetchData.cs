using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x43D35B6DB970549F)]
    public class GcTexturePrefetchData : NMSTemplate
    {
        public List<NMSString0x80> Textures;
    }
}
