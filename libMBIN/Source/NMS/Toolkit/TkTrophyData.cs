using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x3C2D30DB140CBF81)]
    public class TkTrophyData : NMSTemplate
    {
        public List<TkTrophyEntry> Trophies;
    }
}
