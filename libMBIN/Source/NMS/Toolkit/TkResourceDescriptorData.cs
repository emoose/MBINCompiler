using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0ABD3B610D1E296E6)]
    public class TkResourceDescriptorData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Id;
        [NMS(Size = 0x80)]
        public string Name;
        public List<NMSString0x80> ReferencePaths;
        public float Chance;
        public List<NMSTemplate> Children;
    }
}
