using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10, GUID = 0xB7D3E07377C672EF, NameHash = 0xF4500CD57E96D069)]
    public class TkLanguageFontTable : NMSTemplate
    {
        public List<TkLanguageFontTableEntry> Table;
    }
}