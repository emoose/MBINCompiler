using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x62B7549F9EF7703E)]
    public class GcDefaultMissionItemsTable : NMSTemplate
    {
        public List<GcDefaultMissionSubstance> PrimarySubstances;
        public List<GcDefaultMissionSubstance> SecondarySubstances;
        public List<GcDefaultMissionProduct> PrimaryProducts;
        public List<GcDefaultMissionProduct> SecondaryProducts;
    }
}
