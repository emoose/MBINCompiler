using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D33AC9B9ADD17756)]
    public class TkControllerList : NMSTemplate
    {
        public List<TkControllerButtonLookup> Controllers;
    }
}
