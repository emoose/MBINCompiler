using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x0BC8ED0AD6D388727)]
    public class TkEqualityEnum : NMSTemplate
    {
		public enum EqualityEnumEnum { Equal, Greater, Less, GreaterEqual, LessEqual }
		public EqualityEnumEnum EqualityEnum;
    }
}
