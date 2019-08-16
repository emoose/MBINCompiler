using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x78, GUID = 0xEE40FC070E9CAD12, SubGUID = 0x8A35BC3F94D0949F)]
    public class GcPunctuationDelayTable : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public GcPunctuationDelayData[] PunctuationDelays;
    }
}
