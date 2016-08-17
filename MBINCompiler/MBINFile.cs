using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MBINCompiler
{
    class MBINFile
    {
        public MBINHeader Header;
        private readonly IO _io;
        private readonly string _filePath;

        public MBINFile(string path)
        {
            _filePath = path;
            _io = new IO(path);
        }

        public bool Load()
        {
            _io.Stream.Position = 0;
            Header = (MBINHeader)_io.Reader.DeserializeTemplate("MBINHeader");
            return true;
        }

        public bool Save()
        {
            _io.Stream.Position = 0;
           // _io.Writer.WriteStruct(Header);
            _io.Stream.Flush();

            return true;
        }

        public NMSTemplate GetData()
        {
            _io.Stream.Position = 0x60;
            return _io.Reader.DeserializeTemplate(Header.GetXMLTemplateName());
        }

        public string SerializeToXML()
        {
            var obj = GetData();
            if (obj == null)
                return null;

            var xmlDoc = new XmlDocument();
            var el = obj.AppendToXml(null, xmlDoc);

            var xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter, xmlSettings))
            {
                xmlDoc.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                return stringWriter.GetStringBuilder().ToString();
            }
        }
    }
}
