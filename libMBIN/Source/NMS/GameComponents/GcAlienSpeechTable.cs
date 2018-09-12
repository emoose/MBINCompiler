using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6F5BDF62AC518480)]
    public class GcAlienSpeechTable : NMSTemplate
    {
        public List<GcAlienSpeechEntry> Table;
    }
}
