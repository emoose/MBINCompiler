namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCD04DEEE7D62DFD, NameHash = 0xF6BC04E88CDBB164)]
    public class GcObjectDefinitionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Filename;
        // size: 0x2
        public enum ObjectRenderTypeEnum {
            Instanced,
            Single,
        }
        /* 0x80 */ public ObjectRenderTypeEnum ObjectRenderType;
        /* 0x84 */ public bool AutoCollision;
        /* 0x85 */ public bool MatchGroundColour;
        // size: 0x5
        public enum SizeClassEnum {
            Tiny,
            Small,
            Medium,
            Large,
            Massive,
        }
        /* 0x88 */ public SizeClassEnum SizeClass;
        // size: 0x3
        public enum ObjectCoverageTypeEnum {
            Blanket,
            Cluster,
            Solo,
        }
        /* 0x8C */ public ObjectCoverageTypeEnum ObjectCoverageType;
        // size: 0x4
        public enum LifeTypeEnum {
            Rock,
            DryPlant,
            LushPlant,
            Artificial,
        }
        /* 0x90 */ public LifeTypeEnum LifeType;
        // size: 0x4
        public enum LocationTypeEnum {
            AboveGround,
            UnderGround,
            WaterSurface,
            UnderWater,
        }
        /* 0x94 */ public LocationTypeEnum LocationType;
        // size: 0x6
        public enum ObjectAlignmentEnum {
            Upright,
            SlightOffsetFromUpright,
            LargeOffsetFromUpright,
            ToNormal,
            SlightOffsetFromNormal,
            LargeOffsetFromNormal,
        }
        /* 0x98 */ public ObjectAlignmentEnum ObjectAlignment;
    }
}
