using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7917ED329F0F1E74)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        public List<GcProceduralTechnologyData> Table;
    }
}
