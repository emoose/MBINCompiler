namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85A69C2161508834, NameHash = 0x8F2EED19BC2FFF5D)]
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
