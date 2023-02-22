using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2B3F7ACFE888523E, NameHash = 0x3A0F3C26A4978A6F)]
    public class TkAnimationData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Anim;
        /* 0x010 */ public NMSString0x10 AdditiveBaseAnim;
        /* 0x020 */ public NMSString0x80 Filename;
        /* 0x0A0 */ public NMSString0x40 StartNode;
        /* 0x0E0 */ public List<NMSString0x40> ExtraStartNodes;
        /* 0x0F0 */ public TkAnimationGameData GameData;
        /* 0x0F8 */ public int FrameStart;
        /* 0x0FC */ public int FrameEnd;
        /* 0x100 */ public int Priority;
        /* 0x104 */ public float OffsetMin;
        /* 0x108 */ public float OffsetMax;
        /* 0x10C */ public float Delay;
        /* 0x110 */ public float Speed;
        /* 0x114 */ public float ActionStartFrame;
        /* 0x118 */ public float ActionFrame;
        /* 0x11C */ public float AdditiveBaseFrame;
        // size: 0x4
        public enum AnimTypeEnum {
            Loop,
            OneShot,
            Control,
            OneShotBlendable,
        }
        /* 0x120 */ public AnimTypeEnum AnimType;
        // size: 0x3
        public enum CreatureSizeEnum {
            AllSizes,
            SmallOnly,
            LargeOnly,
        }
        /* 0x124 */ public CreatureSizeEnum CreatureSize;
        /* 0x128 */ public bool Additive;
        /* 0x129 */ public bool Mirrored;
        /* 0x12A */ public bool Active;
        /* 0x12B */ public bool Has30HzFrames;
    }
}
