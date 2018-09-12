using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x328BC8722EB81B1F)]
    public class TkResourceDescriptorList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TypeId;
        public List<TkResourceDescriptorData> Descriptors;
    }
}
