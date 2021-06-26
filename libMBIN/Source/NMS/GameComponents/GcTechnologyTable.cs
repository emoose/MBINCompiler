using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x567D5EFD542E519F, NameHash = 0x7BF27C8F05ED20B7)]
    public class GcTechnologyTable : NMSTemplate
    {
        public List<GcTechnology> Table;
    }
}
