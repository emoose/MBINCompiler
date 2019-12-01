using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1621BC90CB4E34F5, NameHash = 0x317FB72CFB424340)]
    public class GcRewardIncrementInteractionIndex : NMSTemplate
    {
        public GcInteractionType InteractionToIncrement;
        public GcAlienRace Race;
    }
}
