using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompilerTests.Database {

    // string TemplateName, int ByteSize
    public class TemplateSizeRecord : AbstractRecord {

        private static string[] COLUMN_HEADINGS = new string[] { "Template", "Size (bytes)" };
        internal override string[] GetColumnHeadings() => COLUMN_HEADINGS;

        public string TemplateName { get; set; }
        public int Size { get; set; }

        public TemplateSizeRecord() { }

        public TemplateSizeRecord( string name, int size ) : this() {
            this.TemplateName = name;
            this.Size = size;
        }

        //public TemplateSizeRecord( string[] fields ) : this() { SetFields( fields ); }

        internal override void SetFields( string[] fields ) {
            TemplateName = fields[0];
            Size = int.Parse( fields[1] );
        }

        internal override string[] GetFields() => new string[] { TemplateName, Size.ToString() };

        //public static explicit operator TemplateSizeRecord( string[] fields ) => new TemplateSizeRecord( fields );

    }

}
