using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace MBINCompiler.Models.Structs
{
    public class GcAIShipSpawnData : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        public string Message;

        public TkInputEnum InputEnum;
        public bool WarpIn;
        public GcAISpaceshipRoles ShipRole;
        public float MinRange;
        public float Scale;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Padding34;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Reward;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
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
