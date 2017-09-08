using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkProceduralTextureLayer : NMSTemplate     // size: 0x40
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;

        /* 0x10 */ public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x18 */ public string Group;

        /* 0x28 */ public bool SelectToMatchBase;
        /* 0x30 */ public List<TkProceduralTexture> Textures;
    }
}
