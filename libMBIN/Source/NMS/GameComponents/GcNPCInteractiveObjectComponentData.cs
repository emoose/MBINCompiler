using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3E2F725E0397C09, NameHash = 0x6EB308F16DDC755C)]
    public class GcNPCInteractiveObjectComponentData : NMSTemplate
    {
        /* 0x00 */ public GcNPCInteractiveObjectType InteractiveObjectType;
        /* 0x04 */ public int MaxCapacity;
        /* 0x08 */ public float DurationMin;
        /* 0x0C */ public float DurationMax;
        /* 0x10 */ public List<GcNPCInteractiveObjectState> States;
    }
}
