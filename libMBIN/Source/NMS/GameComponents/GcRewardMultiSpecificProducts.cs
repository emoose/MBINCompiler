using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x0, NameHash = 0xC87C94C721C64FAA)]
    public class GcRewardMultiSpecificProducts : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string SetName;
        public List<NMSString0x10> ProductIds;
    }
}