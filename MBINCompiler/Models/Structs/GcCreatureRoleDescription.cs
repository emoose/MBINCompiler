using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureRoleDescription : NMSTemplate
    {
        public GcCreatureRoles CreatureRole;
        public GcCreatureTypes CreatureType;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string ForceID;

        public float MinGroupScale;
        public float MaxGroupScale;
        public int MinGroupSize;
        public int MaxGroupSize;
        public float GroupsPerSquareKm;
        public float FractionActiveInDay;
        public float FractionActiveInNight;
        public float ProbabilityOfBeingEnabled;
        public float IncreasedSpawnDistance;
    
        [NMSAttribute(Ignore = true)]
        public int Padding;
    }
}
