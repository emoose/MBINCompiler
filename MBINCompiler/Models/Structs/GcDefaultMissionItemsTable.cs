using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcDefaultMissionItemsTable : NMSTemplate       // size: 0x40
    {
        public List<GcDefaultMissionSubstance> PrimarySubstances;
        public List<GcDefaultMissionSubstance> SecondarySubstances;
        public List<GcDefaulMissionProduct> PrimaryProducts;
        public List<GcDefaulMissionProduct> SecondaryProducts;
    }
}
