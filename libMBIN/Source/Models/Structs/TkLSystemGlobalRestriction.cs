using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public List<TkLSystemRestrictionData> Restrictions;
    }
}
