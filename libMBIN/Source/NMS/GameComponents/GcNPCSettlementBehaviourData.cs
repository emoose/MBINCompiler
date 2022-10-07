using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2BB31AC467459AD, NameHash = 0x87BC5043F293743D)]
    public class GcNPCSettlementBehaviourData : NMSTemplate
    {
        /* 0x00 */ public GcNPCSettlementBehaviourEntry BaseBehaviour;
        // size: 0x5
        public enum BehaviourOverridesEnum {
            Generic,
            Sociable,
            Productive,
            Tired,
            Afraid
        }
        [NMS(Size = 0x5, EnumType = typeof(BehaviourOverridesEnum))]
        /* 0x48 */ public GcNPCSettlementBehaviourEntry[] BehaviourOverrides;
    }
}
