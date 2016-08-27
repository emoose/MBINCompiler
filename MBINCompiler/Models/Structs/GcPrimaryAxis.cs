using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPrimaryAxis : NMSTemplate
    {
        public int PrimaryAxis;
        public string[] PrimaryAxisValues()
        {
            return new[] { "Z", "ZNeg" };
        }
    }
}
