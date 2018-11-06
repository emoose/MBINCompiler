using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x690, GUID = 0xA444343A8262A49C)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        // enum struct: GcPlayerCharacterStateType
        [NMS(Size = 0xE, EnumValue = new[] { "Idle", "Jog", "JogUphill", "JogDownhill", "SteepSlope", "Sliding", "Run", "Airborne", "JetpackBoost",
            "RocketBoost", "Swimming", "SwimmingJetpack", "Death", "FullBodyOverride" })]
        public GcPlayerCharacterState[] CharacterStates;
    }
}
