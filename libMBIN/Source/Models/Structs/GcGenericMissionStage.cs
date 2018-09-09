using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x58, GUID = 0x0E47DADDDF1545211)]
    public class GcGenericMissionStage : NMSTemplate
    {
        public List<GcGenericMissionVersionProgress> Versions;
        public NMSTemplate Stage;
    }
}
