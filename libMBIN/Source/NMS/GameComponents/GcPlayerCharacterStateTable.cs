using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5A0, GUID = 0x1AF5AACC7C3221AB, Broken = true)]
    public class GcPlayerCharacterStateTable : NMSTemplate
    {
        [NMS(Size = 0xC)]
        public GcPlayerCharacterState[] CharacterStates;
    }
}
