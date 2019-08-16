using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8159D3D6B6276FF1)]
    public class GcSelectableObjectList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public GcAlienRace Race;
        public List<GcSelectableObjectData> Options;
    }
}
