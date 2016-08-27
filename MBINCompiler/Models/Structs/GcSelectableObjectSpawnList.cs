using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public List<GcSelectableObjectSpawnData> Objects;
    }
}
