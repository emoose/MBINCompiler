using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x17E5FB422DA99D42, NameHash = 0xE9F8FE2C0612C3FE)]
    public class GcBasePlacementRule : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Conditions;
        /* 0x10 */ public NMSString0x80 PositionLocator;
        /* 0x90 */ public NMSString0x20A PartID;
        /* 0xB0 */ public bool ORConditions;
        // size: 0x5
        public enum TwinCriteriaEnum {
            None,
            MoveToTwin,
            StretchToTwin,
            StretchToRaycast,
            MoveToTwinRelative
        }
        /* 0xB4 */ public TwinCriteriaEnum TwinCriteria;
    }
}
