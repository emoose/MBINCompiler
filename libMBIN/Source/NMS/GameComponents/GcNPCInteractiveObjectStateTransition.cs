using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CC02931E47F4C3A, NameHash = 0x5CE318610D9BD8D9)]
    public class GcNPCInteractiveObjectStateTransition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NewState;
        /* 0x10 */ public float Probability;
        /* 0x18 */ public NMSString0x10 RequireEvent;
        /* 0x28 */ public NMSString0x10 RequireLocator;
        // size: 0x3
        public enum RequireModeEnum {
            Seated,
            Standing,
            None
        }
        /* 0x38 */ public RequireModeEnum RequireMode;
        /* 0x40 */ public List<NMSString0x10> ExcludeTags;
    }
}
