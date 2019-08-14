using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x50366C5FD3D7FE41)]
    public class GcAlienSpeechTable : NMSTemplate
    {
        public List<GcAlienSpeechEntry> Table;
    }
}
