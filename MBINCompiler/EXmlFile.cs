using System.IO;
using System.Xml;
using System.Xml.Serialization;
using MBINCompiler.Models;

namespace MBINCompiler
{
    internal static class EXmlFile
    {
        private static readonly XmlSerializer Serializer = new XmlSerializer(typeof(EXmlData));

        public static NMSTemplate ReadTemplate(string filePath)
        {
            using (var input = File.OpenRead(filePath))
            using (var reader = XmlReader.Create(input))
            {
                EXmlData root = (EXmlData)Serializer.Deserialize(reader);
                NMSTemplate rootTemplate = NMSTemplate.DeserializeXml(root);
                return rootTemplate;
            }
        }
    }
}