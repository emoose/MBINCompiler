using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x641479B85F14BCE5)]
    public class TkAnimPoseExampleData : NMSTemplate // 0x10 bytes
    {
        public List<TkAnimPoseExampleElement> Elements;
    }
}
