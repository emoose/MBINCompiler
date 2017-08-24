using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkAttachmentData : NMSTemplate
    {
        public List<NMSTemplate> Components;
        [NMS(Size = 0x5)]
        public float[] LodDistances;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
