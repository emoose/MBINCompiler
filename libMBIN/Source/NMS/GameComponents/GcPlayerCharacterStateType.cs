using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x891E4FD66AF8A242)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
		public enum CharacterStateEnum { Idle, Jog, JogUphill, JogDownhill, SteepSlope, Sliding, Run, Airborne, JetpackBoost, RocketBoost,
            Swimming, SwimmingJetpack, Death, FullBodyOverride }
		public CharacterStateEnum CharacterState;
    }
}
