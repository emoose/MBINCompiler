using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0AE25FA912062DD1C)]
    public class GcCostStanding : NMSTemplate
    {
        public GcAlienRace AlienRace;
        public int RequiredStanding;
    }
}
