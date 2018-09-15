using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xA066D8CE7219A118)]
    public class TkLanguageFontTable : NMSTemplate
    {
        public List<TkLanguageFontTableEntry> Table;
    }
}
