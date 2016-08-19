using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MBINCompiler.Models;

namespace MBINCompiler
{
    public class MBINFile : IDisposable
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
            Header = (MBINHeader)NMSTemplate.DeserializeBinaryTemplate(_io.Reader, "MBINHeader");
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
            return NMSTemplate.DeserializeBinaryTemplate(_io.Reader, Header.GetXMLTemplateName());
        }

        public void Dispose()
        {
            if (_io != null)
                _io.Dispose();
        }
    }
}
