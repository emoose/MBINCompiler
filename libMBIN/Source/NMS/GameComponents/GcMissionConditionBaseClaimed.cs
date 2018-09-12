using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5C466861A81B8108)]
    public class GcMissionConditionBaseClaimed : NMSTemplate
    {
        /* 0x00 */ public bool Claimed;
        /* 0x04 */ public GcPersistentBaseTypes Base;
		public enum IsOnCurrentSystemEnum { DontCare, Yes, No }
		public IsOnCurrentSystemEnum IsOnCurrentSystem;
    }
}
