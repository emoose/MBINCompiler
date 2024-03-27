using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0C272905A6A0283, NameHash = 0xBD1382185246DF07)]
    public class GcPlayerEmote : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Title;
        /* 0x020 */ public NMSString0x20A ChatText;
        /* 0x040 */ public bool ChatUsesPrefix;
        /* 0x048 */ public NMSString0x10 EmoteID;
        /* 0x058 */ public NMSString0x10 AnimationName;
        /* 0x070 */ public GcPlayerEmotePropData PropData;
        /* 0x1A0 */ public TkTextureResource Icon;
        /* 0x228 */ public NMSString0x10 LinkedSpecialID;
        /* 0x238 */ public bool NeverShowInMenu;
        /* 0x240 */ public NMSString0x10 LoopAnimUntilMove;
        /* 0x250 */ public bool CloseMenuOnSelect;
        /* 0x251 */ public bool MoveToCancel;
        /* 0x258 */ public NMSString0x10 GekAnimationName;
        /* 0x268 */ public NMSString0x10 GekLoopAnimUntilMove;
        /* 0x278 */ public bool AvailableUnderwater;
        /* 0x280 */ public NMSString0x10 RidingAnimationName;
        /* 0x290 */ public bool IsPetCommand;
        /* 0x298 */ public NMSString0x20A PetCommandTitle;
        /* 0x2B8 */ public TkTextureResource PetCommandIcon;
    }
}
