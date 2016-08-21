using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using MBINCompiler.Models;

namespace MBINCompiler
{
    internal static class EXmlFile
    {
        private static readonly XmlSerializer Serializer = new XmlSerializer(typeof(EXmlData));
        private static readonly XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") });
        
        public static NMSTemplate ReadTemplate(string filePath)
        {
            using (var input = File.OpenRead(filePath))
            using (var reader = XmlReader.Create(input))
            {
                EXmlData root = (EXmlData)Serializer.Deserialize(reader);
                NMSTemplate rootTemplate = NMSTemplate.DeserializeEXml(root);
                return rootTemplate;
            }
        }

        public static string WriteTemplate(NMSTemplate template)
        {
            var xmlSettings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8
            };
            using (var stringWriter = new EncodedStringWriter(Encoding.UTF8))
            using (var xmlTextWriter = XmlWriter.Create(stringWriter, xmlSettings))
            {
                EXmlData data = template.SerializeEXml();
                Serializer.Serialize(xmlTextWriter, data, Namespaces);
                xmlTextWriter.Flush();
                return stringWriter.GetStringBuilder().ToString();
            }
        }

        private sealed class EncodedStringWriter : StringWriter
        {
            public EncodedStringWriter(Encoding encoding)
            {
                Encoding = encoding;
            }

            public override Encoding Encoding { get; }
        }
    }
}