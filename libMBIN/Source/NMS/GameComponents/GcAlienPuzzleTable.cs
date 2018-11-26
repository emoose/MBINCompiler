using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFEAF1D567D35E0EB)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        public List<GcAlienPuzzleEntry> Table;
    }
}
