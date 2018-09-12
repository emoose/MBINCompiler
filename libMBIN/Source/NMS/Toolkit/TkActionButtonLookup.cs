using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x874F5BC7E66EB51F)]
    public class TkActionButtonLookup : NMSTemplate
    {
        public List<TkActionButtonMap> Lookup;
    }
}
