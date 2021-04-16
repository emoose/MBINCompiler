using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xC8841A9AB67EE8D6, NameHash = 0x4A57F915F84ABBCD)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Mission;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Puzzle;
        /* 0x30 */ public bool ForceMissionSeed;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x31 */ public byte[] EndPadding;
    }
}
