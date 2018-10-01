using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA230678309474A66, Broken = true)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        public List<GcAlienPuzzleEntry> Table;
    }
}
