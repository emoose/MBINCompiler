using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D445ABC63C96EE5, NameHash = 0xD3ED2C768AB1847C)]
    public class GcPetTraitMoodModifierList : NMSTemplate
    {
        // size: 0x2
        public enum ModifiersEnum {
            Hungry,
            Lonely
        }
        [NMS(Size = 0x2, EnumType = typeof(ModifiersEnum))]
        /* 0x0 */ public GcPetTraitMoodModifier[] Modifiers;
    }
}
