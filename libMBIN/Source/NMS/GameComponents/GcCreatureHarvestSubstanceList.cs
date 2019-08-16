using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0x9BDF0DD3F1318373, SubGUID = 0xC8FD5EE28A99CF03)]
    public class GcCreatureHarvestSubstanceList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CreatureType;
        [NMS(Size = 0x10)]
        public string Item;
        [NMS(Size = 0x80)]
        public string Desc;
    }
}
