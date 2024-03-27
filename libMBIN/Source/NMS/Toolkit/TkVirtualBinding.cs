using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC58C449AB9F25B01, NameHash = 0xD0287A9FD1DC3163)]
    public class TkVirtualBinding : NMSTemplate
    {
        /* 0x00 */ public bool Active;
        /* 0x01 */ public bool DefaultActive;
        /* 0x08 */ public NMSString0x10 HudLayerID;
        /* 0x18 */ public NMSString0x10 SecondaryHudLayerID;
        /* 0x28 */ public List<GcInputActions> TogglableActions;
        /* 0x38 */ public bool SupportsJoystick;
        /* 0x39 */ public bool DirectionalActions;
        /* 0x3C */ public GcInputActions LeftAction;
        /* 0x40 */ public GcInputActions RightAction;
        /* 0x44 */ public GcInputActions TopAction;
        /* 0x48 */ public GcInputActions BottomAction;
    }
}
