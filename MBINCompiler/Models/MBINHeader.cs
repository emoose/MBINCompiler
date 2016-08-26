using System.Runtime.InteropServices;

namespace MBINCompiler.Models
{
    public class MBINHeader : NMSTemplate
    {
        public uint Magic;
        public int Unknown4;
        public long BuildDateTime; // 0x0 for most files, 0xFFFF.. for TkGeometryData files, timestamp eg. 201607201542 (decimal) on global files.
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
            BuildDateTime = 0x706D6F434E49424D;
            Unknown10 = 0x302E3172656C69; // hash of some kind? might be filename hash, checked against 0xFFCA41E11361EE54i64 inside MBIN loading routine, which is value used inside METADATA/UI/LAYOUT.MBIN
            TemplateName = string.Empty;
            Unknown58 = 0; // can be 0xFEFEFE...
        }
    }
}