using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionConditionGroup : NMSTemplate
    {
        public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        public List<NMSTemplate> Conditions;
    }
}
