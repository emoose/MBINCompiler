using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0AFF99D684E9C68AD)]
    public class GcMissionDifficulty : NMSTemplate
    {
		public enum MissionDifficultyEnum { Easy, Normal, Hard }
		public MissionDifficultyEnum MissionDifficulty;
    }
}
