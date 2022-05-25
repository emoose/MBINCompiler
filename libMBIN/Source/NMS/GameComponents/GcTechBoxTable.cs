using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x2D556C95C8283364, NameHash = 0x932307388A9E5FF3)]
    public class GcTechBoxTable : NMSTemplate
    {
        public List<GcTechBoxData> Table;
    }
}
