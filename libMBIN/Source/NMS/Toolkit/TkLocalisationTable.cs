using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8B2AEC2B23D377F3)]
    public class TkLocalisationTable : NMSTemplate
    {
        public List<TkLocalisationEntry> Table;
    }
}
