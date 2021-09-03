using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xBF2847B13563392E, NameHash = 0x6EB308F16DDC755C)]
    public class GcNPCInteractiveObjectComponentData : NMSTemplate
    {
        public GcNPCInteractiveObjectType InteractiveObjectType;
        public int MaxCapacity;
        public float DurationMin;
        public float DurationMax;
        public List<GcNPCInteractiveObjectState> States;
    }
}
