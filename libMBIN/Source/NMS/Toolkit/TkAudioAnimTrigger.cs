using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5410453999AFCEDA, NameHash = 0xC2C9E5EF)]
    public class TkAudioAnimTrigger : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 3)]
        /* 0x10 */ public List<NMSString0x20A> OnlyValidWithParts;
        // size: 0x4
        public enum AudioTypeEnum : uint {
            Standard,
            CreatureVocal,
            CreatureSnore,
            Projectile,
        }
        [NMS(Index = 4)]
        /* 0x20 */ public AudioTypeEnum AudioType;
        [NMS(Index = 2)]
        /* 0x24 */ public int FrameStart;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x80 Sound;
    }
}
