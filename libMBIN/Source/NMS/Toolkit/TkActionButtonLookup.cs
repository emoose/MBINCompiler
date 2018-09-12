using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x874F5BC7E66EB51F)]
    public class TkActionButtonLookup : NMSTemplate
    {
        public List<TkActionButtonMap> Lookup;
    }
}
