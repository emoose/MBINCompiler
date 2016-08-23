using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerSpawnStateData : NMSTemplate
    {
        public Vector4f PlayerPositionInSystem;
        public Vector4f PlayerTransformAt;
        public Vector4f ShipPositionInSystem;
        public Vector4f ShipTransformAt;
        public int LastKnownPlayerState;
        public string[] LastKnownPlayerStateValues()
        {
            return new[] { "OnFoot", "InShip", "OnStation" };
        }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0xC)]
        public byte[] Padding44;
    }
}
