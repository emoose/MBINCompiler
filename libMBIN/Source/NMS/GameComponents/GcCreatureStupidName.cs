using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x70B584A12FB31217)]
    public class GcCreatureStupidName : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public int Count;
        public List<NMSString0x80> Names;
    }
}
