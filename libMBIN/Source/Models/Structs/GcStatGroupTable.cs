using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcStatGroupTable : NMSTemplate
    {
        public List<GcStatGroupData> Table; // called GcStatGroupTable in exe, C# won't let us use same name as class for members though
    }
}
