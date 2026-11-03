namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBB8F897AC7FA718, NameHash = 0x15065B10)]
    public class GcWFCTerrainConstraint : NMSTemplate
    {
        // size: 0x9
        public enum DirectionEnum : uint {
            Left,
            Back,
            Right,
            Forward,
            LeftBack,
            RightBack,
            RightForward,
            LeftForward,
            All,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DirectionEnum Direction;
        // size: 0x3
        public enum LevelsEnum : uint {
            Lower,
            Upper,
            Both,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public LevelsEnum Levels;
        // size: 0x2
        public enum TerrainEnum : uint {
            RequireAbove,
            RequireBelow,
        }
        [NMS(Index = 2)]
        /* 0x8 */ public TerrainEnum Terrain;
    }
}
