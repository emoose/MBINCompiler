using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x8B2AEC2B23D377F3)]
    public class TkLocalisationTable : NMSTemplate
    {
        public List<TkLocalisationEntry> Table;
    }
}
