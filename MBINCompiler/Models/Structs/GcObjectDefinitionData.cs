using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x9C)]
    public class GcObjectDefinitionData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Filename;
        /* 0x80 */ public int ObjectRenderType;
        public string[] ObjectRenderTypeValues()
        {
            return new[] { "Instanced", "Single" };
        }
        /* 0x84 */ public bool AutoCollision;
        /* 0x85 */ public bool MatchGroundColour;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding86;
        /* 0x88 */ public int SizeClass;
        public string[] SizeClassValues()
        {
            return new[] { "Tiny", "Small", "Medium", "Large", "Massive" };
        }
        /* 0x8C */ public int ObjectCoverageType;
        public string[] ObjectCoverageTypeValues()
        {
            return new[] { "Blanket", "Cluster", "Solo" };
        }
        /* 0x90 */ public int LifeType;
        public string[] LifeTypeValues()
        {
            return new[] { "Rock", "DryPlant", "LargePlant", "Artificial" };
        }
        /* 0x94 */ public int LocationType;
        public string[] LocationTypeValues()
        {
            return new[] { "AboveGround", "UnderGround", "WaterSurface", "UnderWater" };
        }
        /* 0x98 */ public int ObjectAlignment;
        public string[] ObjectAlignmentValues()
        {
            return new[] { "Upright", "SlightOffsetFromUpright", "LargeOffsetFromUpright",
                "ToNormal", "SlightOffsetFromNormal", "LargeOffsetFromNormal" };
        }

    }
}
