using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD65533C3D75FF9E4)]
    public class GcAtmosphereList : NMSTemplate
    {
        public List<NMSString0x80> Atmospheres;
    }
}
