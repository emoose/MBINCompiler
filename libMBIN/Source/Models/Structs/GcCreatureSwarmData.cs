using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcCreatureSwarmData : NMSTemplate
    {
        public int MinCount;
        public int MaxCount;
        public float SwarmMovementSpeed;
        public float SwarmMovementRadius;
        public int SwarmMovementType;
        public string[] SwarmMovementTypeValues()
        {
            return new[] { "None", "Circle", "Random", "Search" };
        }

        public float Coherence;
        public float Alignment;
        public float Spacing;
        public float Follow;
        public float Range;
        public float MaxSpeed;
        public float AlignTime;

        public List<NMSString0x10> RepelList;
    }
}
