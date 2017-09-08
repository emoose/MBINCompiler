using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
        public int DefaultProductType;
        public string[] DefaultProductTypeValues()
        {
            return new[] { "None", "PrimaryProduct", "SecondaryProduct" };
        }
    }
}
