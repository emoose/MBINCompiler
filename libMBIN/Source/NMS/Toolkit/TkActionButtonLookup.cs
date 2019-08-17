using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x6A901CD00C8B3BBF, SubGUID = 0x7845DC8347C337B3)]
    public class TkActionButtonLookup : NMSTemplate
    {
        public List<TkActionButtonMap> Lookup;
    }
}
