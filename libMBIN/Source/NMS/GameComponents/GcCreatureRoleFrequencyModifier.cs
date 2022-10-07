namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7A12F4728E8043, NameHash = 0x8F2EED19BC2FFF5D)]
    public class GcCreatureRoleFrequencyModifier : NMSTemplate
    {
        // size: 0x4
        public enum CreatureRoleFrequencyModifierEnum {
            Never,
            Low,
            Normal,
            High
        }
        /* 0x0 */ public CreatureRoleFrequencyModifierEnum CreatureRoleFrequencyModifier;
    }
}
