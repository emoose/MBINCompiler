using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D1584C03A3BC81B, NameHash = 0xB4578AF4AEBD0B11)]
    public class GcNPCWordReactionTable : NMSTemplate
    {
        // size: 0x8
        public enum RacesEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(RacesEnum))]
        /* 0x0 */ public GcNPCWordReactionCategory[] Races;
    }
}
