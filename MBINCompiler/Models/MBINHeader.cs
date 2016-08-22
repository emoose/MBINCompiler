using System.Runtime.InteropServices;

namespace MBINCompiler.Models
{
    public class MBINHeader : NMSTemplate
    {
        public uint Magic;
        public int Unknown4;
        public int Unknown8;
        public int UnknownC;
        public long Unknown10;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        public string TemplateName;

        public long Unknown58;

        public string GetXMLTemplateName()
        {
            if (!TemplateName.StartsWith("c") || TemplateName.Length < 2)
                return TemplateName;

            return TemplateName.Substring(1); // remove the "c" (compiled?) from the start of the template name
        }

        public void SetDefaults()
        {
            Magic = 0xCCCCCCCC; // can also be 0xDDDDDDDD, why?
            Unknown4 = 2500;
            Unknown8 = 0x4E49424D;
            UnknownC = 0x706D6F43;
            Unknown10 = 0x302E3172656C69; // hash of some kind? might be filename hash
            TemplateName = string.Empty;
            Unknown58 = 0; // can be 0xFEFEFE...
        }
    }
}