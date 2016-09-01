using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace MBINCompiler.Models.Structs
{
    public class GcAIShipSpawnData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Message;

        public TkInputEnum InputEnum;
        public bool WarpIn;
        public GcAISpaceshipRoles ShipRole;
        public float MinRange;
        public float Scale;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding34;
        [NMS(Size = 0x10)]
        public string Reward;
        [NMS(Size = 0x20)]
        public string RewardMessage;
        public bool AttackFreighter;
        public Vector2f Spread;
        public Vector2f Count;
        public Vector2f StartTime;
        public int SpawnShape;
        public string[] SpawnShapeValues()
        {
            return new[] { "Sphere", "Cone" };
        }

        public GcShipAIPerformanceArray AIPerformanceArray;

        public List<GcAIShipSpawnData> ChildSpawns;
    }
}
