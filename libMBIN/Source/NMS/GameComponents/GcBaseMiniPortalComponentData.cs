using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x2C4A7AFEA55FC467, NameHash = 0xBBBD45634207B79F)]
    public class GcBaseMiniPortalComponentData : NMSTemplate
    {
        /* 0x0 */ public bool AllowVehicles;
        /* 0x1 */ public bool AllowSpawnedObjects;
        /* 0x2 */ public bool ConnectViaData;
        /* 0x3 */ public bool FlipFacingDirection;
        /* 0x4 */ public int PowerCost;
        public enum EnabledRequirementEnum { BasePower, AbandonedFreighter }
        /* 0x8 */ public EnabledRequirementEnum EnabledRequirement;
    }
}