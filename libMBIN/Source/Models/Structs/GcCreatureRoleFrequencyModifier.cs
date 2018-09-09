namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0C7A12F4728E8043)]
    public class GcCreatureRoleFrequencyModifier : NMSTemplate
    {
		public enum CreatureRoleFrequencyModifierEnum { Never, Low, Normal, High }
		public CreatureRoleFrequencyModifierEnum CreatureRoleFrequencyModifier;
    }
}
