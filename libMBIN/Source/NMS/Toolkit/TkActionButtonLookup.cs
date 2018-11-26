using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x6A901CD00C8B3BBF)]
    public class TkActionButtonLookup : NMSTemplate
    {
        public List<TkActionButtonMap> Lookup;
    }
}
