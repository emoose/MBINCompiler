using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace libMBIN
{
    public static class MXmlFile
    {
        private static readonly XmlSerializer Serializer = new XmlSerializer(typeof(MXmlData));
        private static readonly XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces(new[] { new XmlQualifiedName("", "") });

        private static XmlReaderSettings readerSettings = new XmlReaderSettings();

        public static NMSTemplate ReadTemplate( string filePath ) {
            string templateName;
            return ReadTemplate( filePath, out templateName );
        }

        public static NMSTemplate ReadTemplate(string filePath, out string templateName ) {
            using ( var input = File.OpenRead( filePath ) ) return ReadTemplateFromStream( input, out templateName );
        }

        public static NMSTemplate ReadTemplateFromString( string xml ) {
            string templateName;
            return ReadTemplateFromString( xml, out templateName );
        }

        public static NMSTemplate ReadTemplateFromString( string xml, out string templateName ) {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            readerSettings.IgnoreComments = false;

            using ( var reader = new StringReader( xml ) )
            using ( var xmlReader = XmlReader.Create( reader, readerSettings ) ) {
                var template = ReadTemplateFromXmlReader( xmlReader, out templateName );
                Thread.CurrentThread.CurrentCulture = origCulture;
                return template;
            }
        }

        public static NMSTemplate ReadTemplateFromStream(Stream input) {
            string templateName;
            return ReadTemplateFromStream( input, out templateName );
        }

        public static NMSTemplate ReadTemplateFromStream( Stream input, out string templateName ) {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            readerSettings.IgnoreComments = false;

            using ( var reader = XmlReader.Create( input, readerSettings ) ) {
                var template = ReadTemplateFromXmlReader( reader, out templateName );
                Thread.CurrentThread.CurrentCulture = origCulture;
                return template;
            }
        }

        private static NMSTemplate ReadTemplateFromXmlReader(XmlReader reader) {
            string templateName;
            return ReadTemplateFromXmlReader( reader, out templateName );
        }

        private static NMSTemplate ReadTemplateFromXmlReader( XmlReader reader, out string templateName ) {
            MXmlData root = (MXmlData) Serializer.Deserialize( reader );
            templateName = root?.Template;
            NMSTemplate rootTemplate = NMSTemplate.DeserializeMXml( root );
            return rootTemplate;
        }

        public static MXmlData ReadMXmlDataFromString(string xml)
        {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            readerSettings.IgnoreComments = false;

            using (var reader = new StringReader(xml))
            using (var xmlReader = XmlReader.Create(reader, readerSettings))
            {
                var data = (MXmlData)Serializer.Deserialize(xmlReader);
                Thread.CurrentThread.CurrentCulture = origCulture;
                return data;
            }
        }

        /// <summary>
        /// Writes the NMSTemplate object to an .mxml file.
        /// </summary>
        /// <param name="outputpath">The location to write the .mxml file.</param>
        /// <param name="hideVersionInfo">If true, version info is not written to the MXML file.</param>
        /// <param name="includeTypeInfo">If true, type info is written to the MXML file.</param>
        public static string WriteTemplate(NMSTemplate template) => WriteTemplate(template, false, false);
        /// <summary>
        /// Writes the NMSTemplate object to an .mxml file.
        /// </summary>
        /// <param name="outputpath">The location to write the .mxml file.</param>
        /// <param name="hideVersionInfo">If true, version info is not written to the MXML file.</param>
        /// <param name="includeTypeInfo">If true, type info is written to the MXML file.</param>
        public static string WriteTemplate(NMSTemplate template, bool hideVersionInfo, bool includeTypeInfo)
        {
            var origCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var xmlSettings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8,
                IndentChars = "\t",
                NewLineChars = "\n"
            };
            using (var stringWriter = new EncodedStringWriter(Encoding.UTF8))
            using (var xmlTextWriter = XmlWriter.Create(stringWriter, xmlSettings))
            {
                var ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                string str_ver = $"{ver.Major}.{ver.Minor:00}.{ver.Build}.{ver.Revision}";
                if ( !hideVersionInfo ) xmlTextWriter.WriteComment($"File created using MBINCompiler version ({str_ver})");
                var data = template.SerializeMXml(false, false, includeTypeInfo);
                Serializer.Serialize(xmlTextWriter, data, Namespaces);
                xmlTextWriter.Flush();

                var xmlData = stringWriter.GetStringBuilder().ToString();
                Thread.CurrentThread.CurrentCulture = origCulture;
                return xmlData;
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