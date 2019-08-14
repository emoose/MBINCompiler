using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB3485FD5E06AFA5D)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        public List<GcAlienPuzzleEntry> Table;
    }
}
