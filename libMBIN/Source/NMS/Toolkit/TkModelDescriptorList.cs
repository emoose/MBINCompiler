using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0B22E1ABAB4CBE5F8)]
    public class TkModelDescriptorList : NMSTemplate
    {
        public List<TkResourceDescriptorList> List;
    }
}
