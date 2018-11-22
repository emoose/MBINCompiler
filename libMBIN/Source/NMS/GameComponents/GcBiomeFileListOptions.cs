using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEA40F91AFC046B6C)]
    public class GcBiomeFileListOptions : NMSTemplate
    {
        public List<GcBiomeFileListOption> BiomeFiles;
    }
}
