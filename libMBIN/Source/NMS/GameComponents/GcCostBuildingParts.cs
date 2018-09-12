using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A50B10766E494BB3)]
    public class GcCostBuildingParts : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Description;
        public List<GcBuildingCostPartCount> RequiredParts;
    }
}
