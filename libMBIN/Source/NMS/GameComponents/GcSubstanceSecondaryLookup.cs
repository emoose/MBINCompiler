using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0CED0783DBCA95F60)]
    public class GcSubstanceSecondaryLookup : NMSTemplate     // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string PrimaryID;
        public List<GcSubstanceSecondary> SecondaryChances;
    }
}
