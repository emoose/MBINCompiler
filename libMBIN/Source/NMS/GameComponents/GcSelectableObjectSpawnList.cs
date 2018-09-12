using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x311A462F48D3006)]
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public List<GcSelectableObjectSpawnData> Objects;
    }
}
