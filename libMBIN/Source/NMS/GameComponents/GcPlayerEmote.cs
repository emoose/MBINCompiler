using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1F8, GUID = 0x4B7E84539BE68467, NameHash = 0xBD1382185246DF07)]
    public class GcPlayerEmote : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ChatText;
        /* 0x040 */ public bool ChatUsesPrefix;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x041 */ public byte[] Padding41;
        [NMS(Size = 0x10)]
        /* 0x048 */ public string AnimationName;
        /* 0x058 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0DC */ public byte[] PaddingDC;
        [NMS(Size = 0x10)]
        /* 0x0E0 */ public string LinkedSpecialID;
        /* 0x0F0 */ public bool NeverShowInMenu;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x0F1 */ public byte[] PaddingF1;
        [NMS(Size = 0x10)]
        /* 0x0F8 */ public string LoopAnimUntilMove;
        /* 0x108 */ public bool CloseMenuOnSelect;
        /* 0x109 */ public bool MoveToCancel;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x10A */ public byte[] Padding10A;
        [NMS(Size = 0x10)]
        /* 0x110 */ public string GekAnimationName;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string GekLoopAnimUntilMove;
        /* 0x130 */ public bool AvailableUnderwater;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x131 */ public byte[] Padding131;
        [NMS(Size = 0x10)]
        /* 0x138 */ public string RidingAnimationName;
        /* 0x148 */ public bool IsPetCommand;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x149 */ public byte[] Padding149;
        [NMS(Size = 0x20)]
        /* 0x150 */ public string PetCommandTitle;
        /* 0x170 */ public TkTextureResource PetCommandIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1F4 */ public byte[] EndPadding;
    }
}
