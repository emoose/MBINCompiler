using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB78FB36EFD7C22DA, SubGUID = 0x498BFDCD029948EF)]
    public class GcActionUseType : NMSTemplate
    {
        public enum ActionUseTypeEnum { Active, Hidden, Debug, Obsolete }
        public ActionUseTypeEnum ActionUseType;
    }
}
