using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6A6E24A7EC8AC91F)]
    public class GcDefaultMissionItemsTable : NMSTemplate       // size: 0x40
    {
        public List<GcDefaultMissionSubstance> PrimarySubstances;
        public List<GcDefaultMissionSubstance> SecondarySubstances;
        public List<GcDefaultMissionProduct> PrimaryProducts;
        public List<GcDefaultMissionProduct> SecondaryProducts;
    }
}
