namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF9F37CB6A1E27E76, NameHash = 0xB92478FDE531276E)]
    public class TkNoiseFlattenOptions : NMSTemplate
    {
        // size: 0x3
        public enum FlatteningEnum {
            None,
            Flatten,
            TerrainEdits
        }
        /* 0x0 */ public FlatteningEnum Flattening;
        // size: 0x4
        public enum WaterPlacementEnum {
            None,
            OnWater,
            Underwater,
            UnderwaterOnly
        }
        /* 0x4 */ public WaterPlacementEnum WaterPlacement;
    }
}
