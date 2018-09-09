using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x40, GUID = 0x0AE92E2296A071666)]
    public class GcPlayerCharacterIKStateData : NMSTemplate
    {
        public GcPlayerCharacterStateType State;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        public GcPlayerCharacterIKOverrideData Data;
        public List<GcPlayerCharacterAnimationOverrideData> AnimOverrides;
    }
}
