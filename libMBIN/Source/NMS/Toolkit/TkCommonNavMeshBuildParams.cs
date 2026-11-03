namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x430FC9BEEDF7F1D3, NameHash = 0xE9B2CD5D)]
    public class TkCommonNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float AgentMaxSlopeDegrees;
        [NMS(Index = 0)]
        /* 0x04 */ public float AgentSteepSlopeDegrees;
        [NMS(Index = 10)]
        /* 0x08 */ public float ContourMaxError;
        [NMS(Index = 9)]
        /* 0x0C */ public float ContourMaxLength;
        [NMS(Index = 13)]
        /* 0x10 */ public float DetailMeshMaxError;
        [NMS(Index = 12)]
        /* 0x14 */ public float DetailMeshSampleDistance;
        [NMS(Index = 8)]
        /* 0x18 */ public int RegionMinCellCount;
        [NMS(Index = 11)]
        /* 0x1C */ public bool BuildDetailMesh;
        [NMS(Index = 14)]
        /* 0x1D */ public bool BuildPolyBVH;
        [NMS(Index = 5)]
        /* 0x1E */ public bool ErodeWalkableAreas;
        [NMS(Index = 3)]
        /* 0x1F */ public bool FilterLedgeSpans;
        [NMS(Index = 2)]
        /* 0x20 */ public bool FilterLowHangingObstacles;
        [NMS(Index = 4)]
        /* 0x21 */ public bool FilterWalkableLowHeightSpans;
        [NMS(Index = 7)]
        /* 0x22 */ public bool MarkLowClearanceHeightAreas;
        [NMS(Index = 6)]
        /* 0x23 */ public bool MedianFilterWalkableAreas;
    }
}
