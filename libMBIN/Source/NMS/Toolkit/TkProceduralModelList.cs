using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9808CBC171682435)]
    public class TkProceduralModelList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public List<NMSString0x80> List;
    }
}
