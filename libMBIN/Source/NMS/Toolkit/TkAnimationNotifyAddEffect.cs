using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE2B3EF30D297F35D, NameHash = 0x3129A5A6)]
    public class TkAnimationNotifyAddEffect : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 CharacterLocator;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Effect;
        [NMS(Index = 8)]
        /* 0x20 */ public List<LinkableNMSTemplate> Modules;
        [NMS(Index = 5)]
        /* 0x30 */ public float FacingDirOffset;
        [NMS(Index = 7)]
        /* 0x34 */ public float Scale;
        [NMS(Index = 1)]
        /* 0x38 */ public NMSString0x40 Node;
        [NMS(Index = 6)]
        /* 0x78 */ public bool Attach;
        [NMS(Index = 3)]
        /* 0x79 */ public bool MirrorDuplicate;
        [NMS(Index = 4)]
        /* 0x7A */ public bool UseModelFacingDir;
    }
}
