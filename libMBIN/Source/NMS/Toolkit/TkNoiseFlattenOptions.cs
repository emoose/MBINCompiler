namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x532E92B4CBB9871C, NameHash = 0xFAF6C239)]
    public class TkNoiseFlattenOptions : NMSTemplate
    {
        // size: 0x3
        public enum FlatteningEnum : uint {
            None,
            Flatten,
            TerrainEdits,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FlatteningEnum Flattening;
        // size: 0x4
        public enum WaterPlacementEnum : uint {
            None,
            OnWater,
            Underwater,
            UnderwaterOnly,
        }
        [NMS(Index = 1)]
        /* 0x4 */ public WaterPlacementEnum WaterPlacement;
    }
}
