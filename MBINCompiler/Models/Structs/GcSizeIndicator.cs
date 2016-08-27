using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSizeIndicator : NMSTemplate
    {
        public int SizeIndicator;
        public string[] SizeIndicatorValues()
        {
            return new[] { "Small", "Medium", "Large" };
        }
    }
}
