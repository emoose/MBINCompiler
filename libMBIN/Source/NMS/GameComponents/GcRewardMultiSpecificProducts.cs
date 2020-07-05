using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x95BADBB6B5F2768, NameHash = 0xC87C94C721C64FAA)]
    public class GcRewardMultiSpecificProducts : NMSTemplate
    {
        public List<NMSString0x10> ProductIds;
    }
}