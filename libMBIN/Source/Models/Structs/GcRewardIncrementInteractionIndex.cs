using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0C077DBEECAE0D84B)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        public int InteractionToIncrement;
        public GcAlienRace Race;
    }
}
