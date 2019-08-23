using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x26599B6CD07A5219, SubGUID = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        public GcActionUseType Status;
        public GcInputActions Action;
    }
}
