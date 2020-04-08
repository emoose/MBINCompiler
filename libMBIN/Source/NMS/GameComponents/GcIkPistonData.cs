using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x200, GUID = 0x88ACCDCEEABFEB00, NameHash = 0x1C7FB8C61B710244)]
    public class GcIkPistonData : NMSTemplate
    {
        [NMS(Size = 0x100)]
        public string Joint1Name;
        [NMS(Size = 0x100)]
        public string Joint2Name;
    }
}
