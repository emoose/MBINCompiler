using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x0E47DADDDF1545211)]
    public class GcGenericMissionStage : NMSTemplate
    {
        public List<GcGenericMissionVersionProgress> Versions;
        public NMSTemplate Stage;
    }
}
