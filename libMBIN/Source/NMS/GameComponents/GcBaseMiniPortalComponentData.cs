using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2, GUID = 0x18814809EBFE374D, NameHash = 0xBBBD45634207B79F)]
    public class GcBaseMiniPortalComponentData : NMSTemplate
    {
        public bool AllowVehicles;
        public bool AllowSpawnedObjects;
    }
}