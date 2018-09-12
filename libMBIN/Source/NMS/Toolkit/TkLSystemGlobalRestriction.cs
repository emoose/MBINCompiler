using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4C98B666C4454E5A)]
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public List<TkLSystemRestrictionData> Restrictions;
    }
}
