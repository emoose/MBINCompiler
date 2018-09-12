using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x16E4F82DDAE16AA0)]
    public class GcAlienPuzzleTable : NMSTemplate
    {
        public List<GcAlienPuzzleEntry> Table;
    }
}
