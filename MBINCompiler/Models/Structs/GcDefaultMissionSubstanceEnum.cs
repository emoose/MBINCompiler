using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
        public int DefaultSubstanceType;
        public string[] DefaultSubstanceTypeValues()
        {
            return new[] { "None", "PrimarySubstance", "SecondarySubstance" };
        }
    }
}
