namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x4, GUID = 0x0FFCDB89406ED07BD)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
		public enum CombatTypeEnum { GroundCombat, SpaceCombat }
		public CombatTypeEnum CombatType;
    }
}
