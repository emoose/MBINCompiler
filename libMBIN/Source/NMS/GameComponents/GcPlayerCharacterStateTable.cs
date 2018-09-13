using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x618, GUID = 0x1AF5AACC7C3221AB)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new[] { "Idle", "Jog", "JogUphill", "JogDownhill", "SteepSlope", "Sliding", "Run", "Airborne", "JetpackBoost", "RocketBoost", "Swimming", "Death", "FullBodyOverride" })]
        public GcPlayerCharacterState[] CharacterStates;
    }
}
