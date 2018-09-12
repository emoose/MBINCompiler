using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0B3B6D25E12E7E323)]
    public class GcStatGroupTable : NMSTemplate
    {
        public List<GcStatGroupData> Table; // called GcStatGroupTable in exe, C# won't let us use same name as class for members though
    }
}
