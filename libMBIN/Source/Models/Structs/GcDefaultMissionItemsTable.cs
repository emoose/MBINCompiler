using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcDefaultMissionItemsTable : NMSTemplate       // size: 0x40
    {
        public List<GcDefaultMissionSubstance> PrimarySubstances;
        public List<GcDefaultMissionSubstance> SecondarySubstances;
        public List<GcDefaultMissionProduct> PrimaryProducts;
        public List<GcDefaultMissionProduct> SecondaryProducts;
    }
}
