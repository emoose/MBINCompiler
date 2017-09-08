namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x94)]
    public class GcTerrainEditing : NMSTemplate
    {
        /* 0x0 */ public float EditPlaneMaxAdditiveOffsetFactor;
        /* 0x4 */ public float EditPlaneMinAdditiveOffsetFactor;
        /* 0x8 */ public float EditPlaneMaxSubtractiveOffsetFactor;
        /* 0xC */ public float EditPlaneMinSubtractiveOffsetFactor;
        /* 0x10 */ public float TerrainEditBeamMaxRange;
        /* 0x14 */ public float TerrainEditBeamAddInterpolationStepFactor;
        /* 0x18 */ public float TerrainEditBeamSubtractInterpolationStepFactor;
        /* 0x1C */ public float TerrainBlocksSearchRadiusMultiplier;
        /* 0x20 */ public float RegionMapSearchRadiusMultiplier;
        /* 0x24 */ public float MinimumSubstancePresence;
        /* 0x28 */ public float RegionEditAreaMultiplier;
        /* 0x2C */ public float DensityBlendDistanceMultiplier;
        /* 0x30 */ public float TerrainEditBaseDistanceTolerance;
        /* 0x34 */ public float TerrainEditsNormalCostFactor;
        /* 0x38 */ public float TerrainEditsSurvivalCostFactor;
        /* 0x3C */ public float VoxelsDeletedAffectCostFactor;
        /* 0x40 */ public float EditsFreeWithinBaseDistanceSqr;
        /* 0x44 */ public bool EditGunBeamEnabled;
        /* 0x45 */ public bool EditGunParticlesEnabled;
        /* 0x46 */ public bool SubtractGunBeamEnabled;
        /* 0x47 */ public bool SubtractGunParticlesEnabled;
        [NMS(Size = 0x8)]
        /* 0x48 */ public float[] EditSizes;
        [NMS(Size = 0x8)]
        /* 0x68 */ public float[] EffectScales;
        [NMS(Size = 0x2)]
        /* 0x88 */ public float[] BaseEditSize;
        /* 0x90 */ public float EditEffectScale;

    }
}
