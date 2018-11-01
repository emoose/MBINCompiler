using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB60585FD5E994CB8)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        public GcInteractionType InteractionToIncrement;
        public GcAlienRace Race;
    }
}
