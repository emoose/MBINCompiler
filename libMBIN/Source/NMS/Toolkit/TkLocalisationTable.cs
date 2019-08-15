using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x5627895BB950EF14)]
    public class TkLocalisationTable : NMSTemplate
    {
        public List<TkLocalisationEntry> Table;
    }
}
