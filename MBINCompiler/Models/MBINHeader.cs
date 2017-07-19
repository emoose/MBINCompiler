using System;
using System.Reflection;

namespace MBINCompiler.Models
{
    public class MBINHeader : NMSTemplate
    {
        public uint Magic; // can be 0xCCCCCCCC, or 0xDDDDDDDD for MBIN.PC files, probably used to seperate PC files from PS4
        public int Version; // seems to be a version field, game checks this under certain conditions to make sure it's equal to 2500
        //public long BuildDateTime; // 0x0 for most files, 0xFFFF.. for TkGeometryData files, timestamp eg. 201607201542 (decimal) on global files and older MBINs, likely removed the code that set it at some stage
        //public long TemplateGUID; // seems to be unique across templates (files using the same template share the same GUID)
        public ulong Tag;
        public ulong MbinVersion;

        [NMS(Size = 0x40)]
        public string TemplateName;

        public ulong EndPadding; // doesn't seem to be used in the game, stores 00.../FE... in the games files

        private string ver;     // Version of the mbin file as read initially as a string

        public string GetXMLTemplateName()
        {
            if (!TemplateName.StartsWith("c") || TemplateName.Length < 2)
                return TemplateName;

            return TemplateName.Substring(1); // remove the "c" (compiled?) from the start of the template name
        }

        public string GetMBINVersion()
        {
            return ver;
        }

        public void SetDefaults()
        {
            Magic = 0xCCCCCCCC;
            Version = 2500;

            Tag = 0x726576434E49424D;
            
            // set the 0x10 bytes to be the MBINCompiler version
            ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            ver = ver.Substring(0, ver.Length - 2).PadRight(0x8, Convert.ToChar(0x00)); // get just the part we need

            char[] bver = ver.ToCharArray();
            MbinVersion = 0;
            for (int i = 0; i < bver.Length; i++)
            {
                MbinVersion += (ulong)Convert.ToUInt16(bver[i]) * (ulong)Math.Pow(16, 2 *i);
            }

            TemplateName = string.Empty;
            EndPadding = 0;
            //Padding58 = ulong.Parse($"{DateTime.Now:yyyyMMddhhmm}"); // may as well make use of this field too
        }
    }
}
