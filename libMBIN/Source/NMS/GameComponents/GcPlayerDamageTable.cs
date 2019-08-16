using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8E78ABF98EBBAF65)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        public List<GcPlayerDamageData> DamageTable;
    }
}
