using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x50, GUID = 0x5CE2B3CBE6B79B10)]
    public class TkAnim2dBlendNodeData : NMSTemplate
    {
        public Vector2f Position;
        public NMSTemplate BlendChild;
    }
}
