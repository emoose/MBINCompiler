using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x544CC9937C378016, NameHash = 0xD67478E5FA6B9871)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        // size: 0x7
        public enum ClassMapEnum {
            Standard,
            PlayerSquadron,
            Freighter,
            CapitalFreighter,
            SmallFreighter,
            TinyFreighter,
            Frigate
        }
        [NMS(Size = 0x7, EnumType = typeof(ClassMapEnum))]
        /* 0x0 */ public GcAISpaceshipInstanceData[] ClassMap;
    }
}
