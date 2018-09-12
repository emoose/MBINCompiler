using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8BBDB1EEE1132923)]
    public class GcTextPresetTable : NMSTemplate
    {
        public List<GcTextPreset> Table;
    }
}
