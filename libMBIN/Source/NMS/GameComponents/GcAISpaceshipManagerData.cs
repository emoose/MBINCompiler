using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB2939C0C576C0AC, NameHash = 0x785665CB6C017B4C)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        // size: 0x5
        public enum SystemSpaceshipsEnum {
            Player,
            Civilian,
            Pirate,
            Police,
            Creature
        }
        [NMS(Size = 0x5, EnumType = typeof(SystemSpaceshipsEnum))]
        /* 0x0 */ public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
