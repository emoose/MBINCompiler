using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC9DD036CB59D969D)]
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string StupidUserName;

        public List<GcCreatureStupidName> Table;
    }
}
