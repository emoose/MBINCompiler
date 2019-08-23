using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC3032469C522EC7B, SubGUID = 0x498BFDCD029948EF)]
    public class GcActionUseType : NMSTemplate
    {
        public enum ActionUseTypeEnum { Active, ActiveVR, ActiveXbox, Hidden, Debug, Obsolete }
        public ActionUseTypeEnum ActionUseType;
    }
}
