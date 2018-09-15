using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xD33AC9B9ADD17756)]
    public class TkControllerList : NMSTemplate
    {
        public List<TkControllerButtonLookup> Controllers;
    }
}
