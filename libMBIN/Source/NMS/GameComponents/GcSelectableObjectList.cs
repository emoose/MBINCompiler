using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x86AB795F2BB3385D)]
    public class GcSelectableObjectList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public GcAlienRace Race;
        public List<GcSelectableObjectData> Options;
    }
}
