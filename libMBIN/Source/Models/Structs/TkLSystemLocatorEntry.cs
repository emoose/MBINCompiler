using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkLSystemLocatorEntry : NMSTemplate // 0x98 bytes
    {
        [NMS(Size = 0x80)]
        public string Model;

        public float Probability;
        public List<TkLSystemRestrictionData> Restrictions;
    }
}
