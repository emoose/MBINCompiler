using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0AA9C24C471BEC131)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
		public enum CharacterStateEnum { Idle, Jog, JogUphill, JogDownhill, SteepSlope, Sliding, Run, Airborne, JetpackBoost, Swimming, Death, FullBodyOverride }
		public CharacterStateEnum CharacterState;
    }
}
