using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x10, GUID = 0x0A2EEBA7E815E0DC4)]
    public class GcFreighterBaseOptions : NMSTemplate
    {
        public List<GcFreighterBaseOption> FreighterBases;
    }
}
