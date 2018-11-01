using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x406D4D23655D11C2)]
    public class GcPlayerCharacterIKStateData : NMSTemplate
    {
        public GcPlayerCharacterStateType State;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        public GcPlayerCharacterIKOverrideData Data;
        public List<GcPlayerCharacterAnimationOverrideData> AnimOverrides;
    }
}
