namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F1A3678D82C9BD3, NameHash = 0xE1192857)]
    public class GcWonderWeirdBasePartCategory : NMSTemplate
    {
        // size: 0xB
        public enum WonderWeirdBasePartCategoryEnum : uint {
            EngineOrb,
            BeamStone,
            BubbleCluster,
            MedGeometric,
            Shard,
            StarJoint,
            BoneGarden,
            ContourPod,
            HydroPod,
            ShellWhite,
            WeirdCube,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WonderWeirdBasePartCategoryEnum WonderWeirdBasePartCategory;
    }
}
