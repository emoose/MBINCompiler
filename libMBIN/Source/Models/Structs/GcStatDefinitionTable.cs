using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x2412C3A937D62ED5)]
    public class GcStatDefinitionTable : NMSTemplate
    {
        public List<GcStatDefinition> StatDefinitionTable;
    }
}
