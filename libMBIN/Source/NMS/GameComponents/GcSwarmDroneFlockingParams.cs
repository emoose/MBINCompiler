namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5079ABC27D7B538, NameHash = 0xD457E7ED)]
    public class GcSwarmDroneFlockingParams : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 6)]
        /* 0x20 */ public float AlignmentWeight;
        [NMS(Index = 8)]
        /* 0x24 */ public float ClusterAttractionWeight;
        [NMS(Index = 3)]
        /* 0x28 */ public float ClusterRadius;
        [NMS(Index = 7)]
        /* 0x2C */ public float CohesionWeight;
        [NMS(Index = 1)]
        /* 0x30 */ public float InfluenceRange;
        [NMS(Index = 12)]
        /* 0x34 */ public float MaxAcceleration;
        [NMS(Index = 13)]
        /* 0x38 */ public float MaxRelativeSpeed;
        [NMS(Index = 9)]
        /* 0x3C */ public float OrbitWeight;
        [NMS(Index = 16)]
        /* 0x40 */ public int ReducedUpdateFrequency;
        [NMS(Index = 4)]
        /* 0x44 */ public float SeparationDistance;
        [NMS(Index = 5)]
        /* 0x48 */ public float SeparationWeight;
        [NMS(Index = 14)]
        /* 0x4C */ public float SpeedDamping;
        [NMS(Index = 15)]
        /* 0x50 */ public float UpdateLODDistance;
        [NMS(Index = 11)]
        /* 0x54 */ public float WanderFrequency;
        [NMS(Index = 10)]
        /* 0x58 */ public float WanderWeight;
        [NMS(Index = 2)]
        /* 0x5C */ public bool TransportWithCluster;
    }
}
