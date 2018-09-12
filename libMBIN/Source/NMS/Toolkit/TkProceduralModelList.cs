using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x9808CBC171682435)]
    public class TkProceduralModelList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public List<NMSString0x80> List;
    }
}
