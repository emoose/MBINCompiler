using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x9573EE834769F5A1, NameHash = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        public GcActionUseType Status;
        public GcInputActions Action;
    }
}