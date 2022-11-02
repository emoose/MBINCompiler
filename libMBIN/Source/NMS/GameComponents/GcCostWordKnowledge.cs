using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78F9CCEE9C7030B1, NameHash = 0x67494CEE3CE0F9F6)]
    public class GcCostWordKnowledge : NMSTemplate
    {
        /* 0x0 */ public GcAlienRace Race;
        // size: 0x2
        public enum RequirementEnum {
            CanLearn,
            CanSpeak
        }
        /* 0x4 */ public RequirementEnum Requirement;
    }
}
