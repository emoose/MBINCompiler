using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0C61664D2E822E1ED)]
    public class GcBiomeFileListOptions : NMSTemplate
    {
        public List<NMSString0x80> BiomeFiles;
    }
}
